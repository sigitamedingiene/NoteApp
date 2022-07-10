namespace NoteApp
{
    partial class PrivateNoteForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userSurnameTextBox = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(59, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 20);
            this.userNameLabel.TabIndex = 1;
            // 
            // userTextBox
            // 
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Location = new System.Drawing.Point(65, 34);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(199, 20);
            this.userTextBox.TabIndex = 2;
            // 
            // userSurnameTextBox
            // 
            this.userSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userSurnameTextBox.Location = new System.Drawing.Point(65, 60);
            this.userSurnameTextBox.Name = "userSurnameTextBox";
            this.userSurnameTextBox.ReadOnly = true;
            this.userSurnameTextBox.Size = new System.Drawing.Size(199, 20);
            this.userSurnameTextBox.TabIndex = 3;
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userId.Location = new System.Drawing.Point(65, 4);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(0, 23);
            this.userId.TabIndex = 5;
            // 
            // PrivateNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1334, 532);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.userSurnameTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "PrivateNoteForm";
            this.Text = "PrivateNoteForm";
            this.Load += new System.EventHandler(this.PrivateNoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox userSurnameTextBox;
        private System.Windows.Forms.Label userId;
    }
}