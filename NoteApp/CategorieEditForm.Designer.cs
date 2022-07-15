namespace NoteApp
{
    partial class CategorieEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieEditForm));
            this.v = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.categorieIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.v.Location = new System.Drawing.Point(5, 7);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(96, 20);
            this.v.TabIndex = 0;
            this.v.Text = "Categorie ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userIdLabel.Location = new System.Drawing.Point(109, 27);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(53, 20);
            this.userIdLabel.TabIndex = 3;
            this.userIdLabel.Text = "UserID";
            // 
            // categorieIdLabel
            // 
            this.categorieIdLabel.AutoSize = true;
            this.categorieIdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categorieIdLabel.Location = new System.Drawing.Point(109, 7);
            this.categorieIdLabel.Name = "categorieIdLabel";
            this.categorieIdLabel.Size = new System.Drawing.Size(89, 20);
            this.categorieIdLabel.TabIndex = 2;
            this.categorieIdLabel.Text = "CategorieID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameTextBox.Location = new System.Drawing.Point(114, 140);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(325, 27);
            this.nameTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 235);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(325, 178);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveChangesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.saveChangesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveChangesButton.Location = new System.Drawing.Point(188, 484);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(157, 33);
            this.saveChangesButton.TabIndex = 8;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // CategorieEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 529);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.categorieIdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.v);
            this.Name = "CategorieEditForm";
            this.Text = "CategorieEditForm";
            this.Load += new System.EventHandler(this.CategorieEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label categorieIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveChangesButton;
    }
}