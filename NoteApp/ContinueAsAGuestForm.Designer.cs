namespace NoteApp
{
    partial class ContinueAsAGuestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorieNameTextBox = new System.Windows.Forms.TextBox();
            this.categorieDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.Label();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categorieSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categorie description:";
            // 
            // categorieNameTextBox
            // 
            this.categorieNameTextBox.Location = new System.Drawing.Point(176, 75);
            this.categorieNameTextBox.Name = "categorieNameTextBox";
            this.categorieNameTextBox.Size = new System.Drawing.Size(310, 27);
            this.categorieNameTextBox.TabIndex = 2;
            // 
            // categorieDescriptionTextBox
            // 
            this.categorieDescriptionTextBox.Location = new System.Drawing.Point(176, 108);
            this.categorieDescriptionTextBox.Multiline = true;
            this.categorieDescriptionTextBox.Name = "categorieDescriptionTextBox";
            this.categorieDescriptionTextBox.Size = new System.Drawing.Size(310, 89);
            this.categorieDescriptionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note name:";
            // 
            // noteText
            // 
            this.noteText.AutoSize = true;
            this.noteText.Location = new System.Drawing.Point(125, 239);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(45, 20);
            this.noteText.TabIndex = 5;
            this.noteText.Text = "Note:";
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.Location = new System.Drawing.Point(176, 203);
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.Size = new System.Drawing.Size(310, 27);
            this.noteNameTextBox.TabIndex = 6;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(176, 236);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(310, 139);
            this.noteTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(292, 381);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(194, 44);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(245, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "CREATE NEW NOTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(631, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "OR SEARCH YOUR NOTES BY CATEGORIE NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Write categorie name:";
            // 
            // categorieSearchTextBox
            // 
            this.categorieSearchTextBox.Location = new System.Drawing.Point(750, 75);
            this.categorieSearchTextBox.Name = "categorieSearchTextBox";
            this.categorieSearchTextBox.Size = new System.Drawing.Size(310, 27);
            this.categorieSearchTextBox.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(866, 108);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(194, 44);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(588, 158);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(472, 267);
            this.infoTextBox.TabIndex = 14;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(12, 9);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(285, 20);
            this.userIdLabel.TabIndex = 15;
            this.userIdLabel.Text = "dff7f95a-eb25-410a-a90a-b4a26b4197eb";
            this.userIdLabel.Visible = false;
            // 
            // ContinueAsAGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categorieSearchTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.noteNameTextBox);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categorieDescriptionTextBox);
            this.Controls.Add(this.categorieNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContinueAsAGuestForm";
            this.Text = "ContinueAsAGuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categorieNameTextBox;
        private System.Windows.Forms.TextBox categorieDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noteText;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categorieSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label userIdLabel;
    }
}