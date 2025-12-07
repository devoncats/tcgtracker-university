using System;
using System.Windows.Forms;
using TCGTracker.Core;

namespace TCGTracker.UI
{
    public partial class AddCardForm : Form
    {
        private readonly TCGTrackerService _service = new TCGTrackerService();
        private readonly string username;

        public AddCardForm(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            string cardName = NameTextBox.Text;
            string cardSet = SetTextBox.Text;
            string cardNumber = NumberTextBox.Text;
            string cardRarity = RarityTextBox.Text;
            string cardCondition = ConditionTextBox.Text;

            if(string.IsNullOrEmpty(cardName) || string.IsNullOrEmpty(cardSet) || string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(cardRarity) || string.IsNullOrEmpty(cardCondition))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            if (!decimal.TryParse(PriceTextBox.Text, out decimal cardPrice))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            
            var card = new Card
            {
                CardId = 0,
                Name = cardName,
                Set = cardSet,
                Number = cardNumber,
                Rarity = cardRarity,
                Price = cardPrice,
                Condition = cardCondition,
                CreatedAt = DateTime.Now,
            };

            try
            {
                _service.CreateCard(card);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred while creating the card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            

            var collection = new Collection
            {
                Username = username,
                Card = card,
            };

            try
            {
                _service.CreateCollection(collection);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred while creating the collection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

            MessageBox.Show("Add Card successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}