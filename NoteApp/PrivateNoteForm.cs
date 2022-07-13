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
        }
        private void PrivateNoteForm_Load(object sender, System.EventArgs e)
        {
            userIdLabel.Text = LogInForm.SetValueForUserId;
            userTextBox.Text = LogInForm.SetValueForUserName;
            userSurnameTextBox.Text = LogInForm.SetValueForUserSurName;
            AddNoteNameByUserToList();
            AddCategorieByUserToList();
            Guid userId = Guid.Parse(userIdLabel.Text);
            var notes = findData.FindNotesByUser(userId);
            for (int i = 0; i < notes.Count; i++)
            {
                noteListView.AppendText($"Note name: {notes[i].Name}; Record: {notes[i].Record}\r\n");
            }
        }
        private void AddCategorieByUserToList()
         {   
            Guid userId = Guid.Parse(userIdLabel.Text);
            List<Categorie> categorieList = findData.FindCategorieByUserId(userId);
             for (int i = 0; i < categorieList.Count; i++)
             {
                 categorieListBox.Items.Add(categorieList[i].Name);
                 categorieNameList.Items.Add(categorieList[i].Name);
             }
         }
        private void AddNoteNameByUserToList()
        {
            Guid userId = Guid.Parse(userIdLabel.Text);
            List<Note> noteList = findData.FindNotesByUser(userId);
            for (int i = 0; i < noteList.Count; i++)
            {
                noteNameList.Items.Add(noteList[i].Name);
            }
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
                Guid userId = Guid.Parse(userIdLabel.Text);
                addData.AddNewCategorie(name, true, description, userId);
                //categorieListBox.Items.Add(name);
                //categorieNameList.Items.Add(name);
                categorieNameList.Items.Add(name);
                categorieListBox.Items.Add(name);
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
            searchTextBox.Clear();
            var note = findData.FindNoteByName(noteNameList.Text);
            searchTextBox.AppendText($"Name: {note.Name};\r\n Note: {note.Record}\r\n");
        }
        private void searchNotesByCategorie_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            var categorie = findData.FindNotesBycategorieName(categorieListBox.Text);
            for (int i = 0; i < categorie.Count; i++)
            {
                searchTextBox.AppendText($"Note name: {categorie[i].Name}\r\n Record: {categorie[i].Record}\r\n");
            }           
        }
    }
}
