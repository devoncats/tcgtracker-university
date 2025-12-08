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
            RefreshCollection();
        }

        private void RefreshCollection()
        {
            var collection = _service.GetCollectionByUser(_username)
                .Where(c => c.Card != null)
                .Select(c => new
                {
                    c.Card.CardId,
                    c.Card.Name,
                    c.Card.Set,
                    c.Card.Number,
                    c.Card.Rarity,
                    c.Card.Price,
                    c.Card.Condition,
                }).ToList();

            CollectionDataGridView.DataSource = collection;
            CollectionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            using (var addCardForm = new AddCardForm(_username))
            {
                if (addCardForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshCollection();
                }
            }
        }

        private void DeleteCardButton_Click(object sender, EventArgs e)
        {
            using (var deleteCardForm = new DeleteCardForm(_username))
            {
                if (deleteCardForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshCollection();
                }
            }
        }
    }
}
