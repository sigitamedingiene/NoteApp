using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NoteAppBusiness.Serivices;
using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteApp
{
    public partial class PrivateNoteForm : Form
    {
        public static DbContent _content = new();
        AddDataToDataBase addData = new(_content);
        FindDataInDataBase findData = new(_content);        
        public PrivateNoteForm()
        {
            InitializeComponent();
            AddCategorieToList();
        }
        private void PrivateNoteForm_Load(object sender, System.EventArgs e)
        {
            userIdLabel.Text = LogInForm.SetValueForUserId;
            userTextBox.Text = LogInForm.SetValueForUserName;
            userSurnameTextBox.Text = LogInForm.SetValueForUserSurName;
        }
        private void AddCategorieToList()
        {
            List<Categorie> categorieList = findData.FindAllCategories();
            for (int i = 0; i < categorieList.Count; i++)
            {
                categorieListBox.Items.Add(categorieList[i].Name);
                categorieNameList.Items.Add(categorieList[i].Name);
            }
        }
        private void AddNotesNameByUserToList()
        {
            Guid userId = Guid.Parse(userIdLabel.Text);
            List<Note> noteList = findData.FindNotesByUser(userId);
        }
        private void CreateNewCategorieButton_Click(object sender, System.EventArgs e)
        {
            string name = categorieNameTextBox.Text;
            var categorie = findData.FindCategorieByName(name);
            if (categorie != null)
            {
                MessageBox.Show("This categorie allready exists. Please choose from the list below, or enter new one.");
            } else
            {
                string description = descriptionTextBox.Text;
                addData.AddNewCategorie(name, true, description);
                categorieListBox.Items.Add(name);
                categorieNameList.Items.Add(name);
                MessageBox.Show("Categorie created succsesfully.");
                categorieNameTextBox.Clear();
                descriptionTextBox.Clear();                
            }           
        }
        private void uploadPhoto_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jepg;.*.gif;) |*.jpg;*.jepg;.*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                uploadPictureBox.Image = new Bitmap(openFile.FileName);
            }
        }
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            string name = noteNameTextBox.Text;
            string record = noteTextBox.Text;
            Guid userId = Guid.Parse(userIdLabel.Text);
            var categorie = findData.FindCategorieByName(categorieNameList.Text);
            Guid categorieId = categorie.Id;
            var user = findData.FindUserById(userId);
            addData.AddNewNote(name, record, true, "file.path", categorieId, userId);
            var note = findData.FindNoteByName(name);            
            addData.AddNoteToUser(user, note);
            addData.AddNoteToCategorie(categorie, note);
            MessageBox.Show("Note created succsesfully");
        }

        private void searchNoteByNameButton_Click(object sender, EventArgs e)
        {
            var note = 9;
            searchTextBox.AppendText($"{ note}");
        }
    }
}
