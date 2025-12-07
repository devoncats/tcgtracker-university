using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TCGTracker.Core;

namespace TCGTracker.UI
{
    public partial class DeleteCardForm : Form
    {
        private readonly TCGTrackerService _service = new TCGTrackerService();
        private readonly string _username;

        public DeleteCardForm(string username)
        {
            _username = username;

            InitializeComponent();
        }

        private void DeleteCardButton_Click(object sender, EventArgs e)
        {
            var id = IDTextBox.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a Card ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            if (!int.TryParse(id, out int parsedId))
            {
                MessageBox.Show("Please enter a valid Card ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            try
            {
                _service.DeleteCollectionByCard(_username, parsedId);
            }
            catch (KeyNotFoundException error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;

                return;
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred while deleting the card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            MessageBox.Show("Card deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
