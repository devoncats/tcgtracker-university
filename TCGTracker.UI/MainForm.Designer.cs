namespace TCGTracker.UI
{
    partial class MainForm
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
            this.CollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.AddCardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CollectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CollectionDataGridView
            // 
            this.CollectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CollectionDataGridView.Location = new System.Drawing.Point(12, 12);
            this.CollectionDataGridView.Name = "CollectionDataGridView";
            this.CollectionDataGridView.Size = new System.Drawing.Size(776, 426);
            this.CollectionDataGridView.TabIndex = 0;
            // 
            // AddCardButton
            // 
            this.AddCardButton.Location = new System.Drawing.Point(12, 444);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(109, 31);
            this.AddCardButton.TabIndex = 1;
            this.AddCardButton.Text = "Add Card";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.CollectionDataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CollectionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CollectionDataGridView;
        private System.Windows.Forms.Button AddCardButton;
    }
}