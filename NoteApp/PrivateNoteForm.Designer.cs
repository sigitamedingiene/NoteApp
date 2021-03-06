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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateNoteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchNotesByCategorie = new System.Windows.Forms.Button();
            this.searchNoteByNameButton = new System.Windows.Forms.Button();
            this.categorieListBox = new System.Windows.Forms.ComboBox();
            this.noteNameList = new System.Windows.Forms.ComboBox();
            this.CreateNewCategorieButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorieNameTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.noteListView = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.imgFilePath = new System.Windows.Forms.Label();
            this.uploadPhoto = new System.Windows.Forms.Button();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.categorieNameList = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.pictureImageList = new System.Windows.Forms.ImageList(this.components);
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userIdLabel.Location = new System.Drawing.Point(59, 9);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(0, 20);
            this.userIdLabel.TabIndex = 1;
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.Teal;
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.userTextBox.ForeColor = System.Drawing.Color.MintCream;
            this.userTextBox.Location = new System.Drawing.Point(624, 7);
            this.userTextBox.Multiline = true;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userTextBox.Size = new System.Drawing.Size(586, 27);
            this.userTextBox.TabIndex = 2;
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
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.searchNotesByCategorie);
            this.splitContainer1.Panel1.Controls.Add(this.searchNoteByNameButton);
            this.splitContainer1.Panel1.Controls.Add(this.categorieListBox);
            this.splitContainer1.Panel1.Controls.Add(this.noteNameList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.CreateNewCategorieButton);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.categorieNameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1310, 139);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Or choose categorie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose note name:";
            // 
            // searchNotesByCategorie
            // 
            this.searchNotesByCategorie.BackColor = System.Drawing.Color.Teal;
            this.searchNotesByCategorie.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.searchNotesByCategorie.ForeColor = System.Drawing.SystemColors.Window;
            this.searchNotesByCategorie.Location = new System.Drawing.Point(274, 92);
            this.searchNotesByCategorie.Name = "searchNotesByCategorie";
            this.searchNotesByCategorie.Size = new System.Drawing.Size(80, 34);
            this.searchNotesByCategorie.TabIndex = 5;
            this.searchNotesByCategorie.Text = "Search";
            this.searchNotesByCategorie.UseVisualStyleBackColor = false;
            this.searchNotesByCategorie.Click += new System.EventHandler(this.searchNotesByCategorie_Click);
            // 
            // searchNoteByNameButton
            // 
            this.searchNoteByNameButton.BackColor = System.Drawing.Color.Teal;
            this.searchNoteByNameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.searchNoteByNameButton.ForeColor = System.Drawing.SystemColors.Window;
            this.searchNoteByNameButton.Location = new System.Drawing.Point(274, 34);
            this.searchNoteByNameButton.Name = "searchNoteByNameButton";
            this.searchNoteByNameButton.Size = new System.Drawing.Size(80, 35);
            this.searchNoteByNameButton.TabIndex = 5;
            this.searchNoteByNameButton.Text = "Search";
            this.searchNoteByNameButton.UseVisualStyleBackColor = false;
            this.searchNoteByNameButton.Click += new System.EventHandler(this.searchNoteByNameButton_Click);
            // 
            // categorieListBox
            // 
            this.categorieListBox.BackColor = System.Drawing.SystemColors.Window;
            this.categorieListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorieListBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categorieListBox.FormattingEnabled = true;
            this.categorieListBox.Location = new System.Drawing.Point(12, 97);
            this.categorieListBox.Name = "categorieListBox";
            this.categorieListBox.Size = new System.Drawing.Size(256, 28);
            this.categorieListBox.TabIndex = 7;
            // 
            // noteNameList
            // 
            this.noteNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noteNameList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noteNameList.FormattingEnabled = true;
            this.noteNameList.Location = new System.Drawing.Point(12, 38);
            this.noteNameList.Name = "noteNameList";
            this.noteNameList.Size = new System.Drawing.Size(256, 28);
            this.noteNameList.Sorted = true;
            this.noteNameList.TabIndex = 6;
            // 
            // CreateNewCategorieButton
            // 
            this.CreateNewCategorieButton.BackColor = System.Drawing.Color.Teal;
            this.CreateNewCategorieButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CreateNewCategorieButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CreateNewCategorieButton.Location = new System.Drawing.Point(718, 82);
            this.CreateNewCategorieButton.Name = "CreateNewCategorieButton";
            this.CreateNewCategorieButton.Size = new System.Drawing.Size(102, 39);
            this.CreateNewCategorieButton.TabIndex = 4;
            this.CreateNewCategorieButton.Text = "Create";
            this.CreateNewCategorieButton.UseVisualStyleBackColor = false;
            this.CreateNewCategorieButton.Click += new System.EventHandler(this.CreateNewCategorieButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(190, 38);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(522, 84);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categorie name:";
            // 
            // categorieNameTextBox
            // 
            this.categorieNameTextBox.Location = new System.Drawing.Point(190, 5);
            this.categorieNameTextBox.Name = "categorieNameTextBox";
            this.categorieNameTextBox.Size = new System.Drawing.Size(522, 27);
            this.categorieNameTextBox.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(384, 206);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer2.Panel1.Controls.Add(this.noteListView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.imgFilePath);
            this.splitContainer2.Panel2.Controls.Add(this.uploadPhoto);
            this.splitContainer2.Panel2.Controls.Add(this.uploadPictureBox);
            this.splitContainer2.Panel2.Controls.Add(this.saveButton);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.noteTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.noteNameTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.categorieNameList);
            this.splitContainer2.Size = new System.Drawing.Size(938, 425);
            this.splitContainer2.SplitterDistance = 576;
            this.splitContainer2.TabIndex = 7;
            // 
            // noteListView
            // 
            this.noteListView.BackColor = System.Drawing.SystemColors.Menu;
            this.noteListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteListView.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteListView.Location = new System.Drawing.Point(33, 59);
            this.noteListView.Multiline = true;
            this.noteListView.Name = "noteListView";
            this.noteListView.ReadOnly = true;
            this.noteListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteListView.Size = new System.Drawing.Size(519, 356);
            this.noteListView.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "CREATE NEW NOTE:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(352, 30);
            this.textBox1.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Choose categorie:";
            // 
            // imgFilePath
            // 
            this.imgFilePath.AutoSize = true;
            this.imgFilePath.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imgFilePath.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.imgFilePath.Location = new System.Drawing.Point(338, 408);
            this.imgFilePath.Name = "imgFilePath";
            this.imgFilePath.Size = new System.Drawing.Size(0, 17);
            this.imgFilePath.TabIndex = 14;
            this.imgFilePath.Visible = false;
            // 
            // uploadPhoto
            // 
            this.uploadPhoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadPhoto.Font = new System.Drawing.Font("Segoe UI Semibold", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.uploadPhoto.Location = new System.Drawing.Point(99, 374);
            this.uploadPhoto.Name = "uploadPhoto";
            this.uploadPhoto.Size = new System.Drawing.Size(61, 48);
            this.uploadPhoto.TabIndex = 12;
            this.uploadPhoto.Text = "Upload picture";
            this.uploadPhoto.UseVisualStyleBackColor = false;
            this.uploadPhoto.Click += new System.EventHandler(this.uploadPhoto_Click);
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadPictureBox.Location = new System.Drawing.Point(12, 374);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(81, 48);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadPictureBox.TabIndex = 11;
            this.uploadPictureBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Teal;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(225, 374);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 48);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Write note:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(12, 179);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(322, 189);
            this.noteTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Write note name:";
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.Location = new System.Drawing.Point(12, 121);
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.Size = new System.Drawing.Size(322, 27);
            this.noteNameTextBox.TabIndex = 5;
            // 
            // categorieNameList
            // 
            this.categorieNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorieNameList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categorieNameList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.categorieNameList.Location = new System.Drawing.Point(12, 62);
            this.categorieNameList.Name = "categorieNameList";
            this.categorieNameList.Size = new System.Drawing.Size(322, 28);
            this.categorieNameList.TabIndex = 13;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 213);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.ReadOnly = true;
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchTextBox.Size = new System.Drawing.Size(366, 103);
            this.searchTextBox.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(271, 318);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(107, 29);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(271, 353);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 29);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Location = new System.Drawing.Point(1216, 5);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(106, 29);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // pictureImageList
            // 
            this.pictureImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.pictureImageList.ImageSize = new System.Drawing.Size(70, 70);
            this.pictureImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(35, 395);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(343, 236);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 10;
            this.imgBox.TabStop = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.Color.Teal;
            this.idLabel.Location = new System.Drawing.Point(24, 319);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(15, 11);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(9, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "SEARCH NOTES:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(384, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "CREATE NEW CATEGORIE:";
            // 
            // PrivateNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1334, 641);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.label1);
            this.Name = "PrivateNoteForm";
            this.Text = "PrivateNoteForm";
            this.Load += new System.EventHandler(this.PrivateNoteForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CreateNewCategorieButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categorieNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchNotesByCategorie;
        private System.Windows.Forms.Button searchNoteByNameButton;
        private System.Windows.Forms.ComboBox categorieListBox;
        private System.Windows.Forms.ComboBox noteNameList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.Button uploadPhoto;
        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.ComboBox categorieNameList;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TextBox noteListView;
        private System.Windows.Forms.Label imgFilePath;
        private System.Windows.Forms.ImageList pictureImageList;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}