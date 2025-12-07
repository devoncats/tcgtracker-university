using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCGTracker.UI
{
    public partial class DeleteCardForm : Form
    {
        public DeleteCardForm()
        {
            InitializeComponent();
        }

        private void DeleteCardButton_Click(object sender, EventArgs e)
        {
            var cardIdText = IDTextBox.Text;
            if(string.IsNullOrEmpty(cardIdText))
            {
                MessageBox.Show("Please enter a Card ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(cardIdText, out int cardId))
            {
                MessageBox.Show("Please enter a valid Card ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
