namespace NoteApp
{
    partial class NoteEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.noteIdLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.recordTextBox = new System.Windows.Forms.TextBox();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.uploadNewPhotoButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note ID:";
            // 
            // noteIdLabel
            // 
            this.noteIdLabel.AutoSize = true;
            this.noteIdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.noteIdLabel.Location = new System.Drawing.Point(82, 29);
            this.noteIdLabel.Name = "noteIdLabel";
            this.noteIdLabel.Size = new System.Drawing.Size(55, 20);
            this.noteIdLabel.TabIndex = 1;
            this.noteIdLabel.Text = "NoteId";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(97, 150);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 23);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Photo:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Location = new System.Drawing.Point(170, 150);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(368, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // recordTextBox
            // 
            this.recordTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.recordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordTextBox.Location = new System.Drawing.Point(170, 201);
            this.recordTextBox.Multiline = true;
            this.recordTextBox.Name = "recordTextBox";
            this.recordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recordTextBox.Size = new System.Drawing.Size(368, 101);
            this.recordTextBox.TabIndex = 6;
            // 
            // photoBox
            // 
            this.photoBox.BackColor = System.Drawing.Color.Transparent;
            this.photoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.photoBox.Location = new System.Drawing.Point(170, 326);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(268, 180);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoBox.TabIndex = 7;
            this.photoBox.TabStop = false;
            // 
            // uploadNewPhotoButton
            // 
            this.uploadNewPhotoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.uploadNewPhotoButton.Location = new System.Drawing.Point(444, 451);
            this.uploadNewPhotoButton.Name = "uploadNewPhotoButton";
            this.uploadNewPhotoButton.Size = new System.Drawing.Size(94, 55);
            this.uploadNewPhotoButton.TabIndex = 8;
            this.uploadNewPhotoButton.Text = "Upload new photo";
            this.uploadNewPhotoButton.UseVisualStyleBackColor = true;
            this.uploadNewPhotoButton.Click += new System.EventHandler(this.uploadNewPhotoButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.saveChangesButton.Location = new System.Drawing.Point(224, 527);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(218, 31);
            this.saveChangesButton.TabIndex = 9;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(412, 233);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(0, 20);
            this.filePathLabel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "User ID:";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userIdLabel.Location = new System.Drawing.Point(81, 9);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(51, 20);
            this.userIdLabel.TabIndex = 12;
            this.userIdLabel.Text = "UserId";
            // 
            // NoteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(604, 570);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.uploadNewPhotoButton);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.recordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.noteIdLabel);
            this.Controls.Add(this.label1);
            this.Name = "NoteEditForm";
            this.Text = "NoteEditForm";
            this.Load += new System.EventHandler(this.NoteEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noteIdLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox recordTextBox;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Button uploadNewPhotoButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userIdLabel;
    }
}