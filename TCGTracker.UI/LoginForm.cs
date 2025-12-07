using System.Collections.Generic;
using System.Windows.Forms;
using TCGTracker.Core;

namespace TCGTracker.UI
{
    public partial class LoginForm : Form
    {
        private readonly TCGTrackerService _service = new TCGTrackerService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, System.EventArgs args)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                var user = _service.GetUserByUsername(username);

                if (user.Password != password)
                {
                    MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Hide();

            var mainForm = new MainForm(username);
            mainForm.FormClosed += (s, e) => this.Close();
            mainForm.Show();
        }
    }
}