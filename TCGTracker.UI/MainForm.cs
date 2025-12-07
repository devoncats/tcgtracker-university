using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCGTracker.Core;

namespace TCGTracker.UI
{
    public partial class MainForm : Form
    {
        private readonly string _username;
        private readonly TCGTrackerService _service = new TCGTrackerService();

        public MainForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var collection = _service.GetCollectionByUser(_username);

            CollectionDataGridView.DataSource = collection;
            CollectionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            var addCardForm = new AddCardForm(_username);
            addCardForm.ShowDialog();
        }

        private void DeleteCardButton_Click(object sender, EventArgs e)
        {
            var deleteCardForm = new DeleteCardForm(_username);
            deleteCardForm.ShowDialog();
        }
    }
}
