namespace TCGTracker.UI
{
    partial class DeleteCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteCardButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CardIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteCardButton
            // 
            this.DeleteCardButton.Location = new System.Drawing.Point(15, 60);
            this.DeleteCardButton.Name = "DeleteCardButton";
            this.DeleteCardButton.Size = new System.Drawing.Size(192, 23);
            this.DeleteCardButton.TabIndex = 17;
            this.DeleteCardButton.Text = "Delete";
            this.DeleteCardButton.UseVisualStyleBackColor = true;
            this.DeleteCardButton.Click += new System.EventHandler(this.DeleteCardButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(90, 11);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(117, 20);
            this.IDTextBox.TabIndex = 16;
            // 
            // CardIDLabel
            // 
            this.CardIDLabel.AutoSize = true;
            this.CardIDLabel.Location = new System.Drawing.Point(12, 18);
            this.CardIDLabel.Name = "CardIDLabel";
            this.CardIDLabel.Size = new System.Drawing.Size(43, 13);
            this.CardIDLabel.TabIndex = 15;
            this.CardIDLabel.Text = "Card ID";
            // 
            // DeleteCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 94);
            this.Controls.Add(this.DeleteCardButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.CardIDLabel);
            this.Name = "DeleteCardForm";
            this.Text = "Delete Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteCardButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label CardIDLabel;
    }
}