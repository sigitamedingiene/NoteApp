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
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note ID:";
            // 
            // noteIdLabel
            // 
            this.noteIdLabel.AutoSize = true;
            this.noteIdLabel.Location = new System.Drawing.Point(77, 31);
            this.noteIdLabel.Name = "noteIdLabel";
            this.noteIdLabel.Size = new System.Drawing.Size(55, 20);
            this.noteIdLabel.TabIndex = 1;
            this.noteIdLabel.Text = "NoteId";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(73, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Photo:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(368, 27);
            this.nameTextBox.TabIndex = 5;
            // 
            // recordTextBox
            // 
            this.recordTextBox.Location = new System.Drawing.Point(138, 109);
            this.recordTextBox.Multiline = true;
            this.recordTextBox.Name = "recordTextBox";
            this.recordTextBox.Size = new System.Drawing.Size(368, 104);
            this.recordTextBox.TabIndex = 6;
            // 
            // photoBox
            // 
            this.photoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.photoBox.Location = new System.Drawing.Point(138, 233);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(268, 168);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoBox.TabIndex = 7;
            this.photoBox.TabStop = false;
            // 
            // uploadNewPhotoButton
            // 
            this.uploadNewPhotoButton.Location = new System.Drawing.Point(412, 303);
            this.uploadNewPhotoButton.Name = "uploadNewPhotoButton";
            this.uploadNewPhotoButton.Size = new System.Drawing.Size(94, 98);
            this.uploadNewPhotoButton.TabIndex = 8;
            this.uploadNewPhotoButton.Text = "Upload new photo";
            this.uploadNewPhotoButton.UseVisualStyleBackColor = true;
            this.uploadNewPhotoButton.Click += new System.EventHandler(this.uploadNewPhotoButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(138, 407);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(368, 31);
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
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "User ID:";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(77, 11);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(51, 20);
            this.userIdLabel.TabIndex = 12;
            this.userIdLabel.Text = "UserId";
            // 
            // NoteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
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