using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TCGTracker.Core;

namespace TCGTracker.UI
{
    public partial class AddCardForm : Form
    {
        private readonly TCGTrackerService _service = new TCGTrackerService();
        public AddCardForm(string _username)
        {
            InitializeComponent();
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            string cardId = IDTextBox.Text;
            string cardName = NameTextBox.Text;
            string cardSet = SetTextBox.Text;
            string cardNumber = NumberTextBox.Text;
            string cardRarity = RarityTextBox.Text;
            string cardCondition = ConditionTextBox.Text;

            if(string.IsNullOrEmpty(cardId) || string.IsNullOrEmpty(cardName) || string.IsNullOrEmpty(cardSet) || string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(cardRarity) || string.IsNullOrEmpty(cardCondition))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(PriceTextBox.Text, out decimal cardPrice))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var card = new TCGTracker.Core.Card
            {
                CardId = int.Parse(cardId),
                Name = cardName,
                Set = cardSet,
                Number = cardNumber,
                Rarity = cardRarity,
                Price = cardPrice
            };

            _service.CreateCard(card);
        }
    }
}
