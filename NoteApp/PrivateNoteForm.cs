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
        RemoveDataFromDataBase removeData = new(_content);
        public static string SetValueForNoteOrCategorieId = "";
        public static string SetValueForUserId = "";
        public PrivateNoteForm()
        {
            InitializeComponent();
        }
        private void PrivateNoteForm_Load(object sender, System.EventArgs e)
        {
            userIdLabel.Text = LogInForm.SetValueForUserId;
            userTextBox.Text = LogInForm.SetValueForUserName;
            userSurnameTextBox.Text = LogInForm.SetValueForUserSurName;
            Guid userId = Guid.Parse(userIdLabel.Text);
            AddNoteNameByUserToList(userId);
            AddCategorieByUserToList(userId);            
            var notes = findData.FindNotesByUser(userId);
            var categories = findData.FindCategorieByUserId(userId);
            for (int i = 0; i < notes.Count; i++)
            {
                for (int j = 0; j < categories.Count; j++)
                {
                    if(notes[i].CategorieId == categories[j].Id)
                    {                        
                        if(notes[i].PhotoUrl == null)
                        {
                            noteListView.AppendText($"\r\nCategorie: {categories[j].Name};\r\nNote name: {notes[i].Name}; Record: {notes[i].Record};");
                        }
                        noteListView.AppendText($"\r\nCategorie: {categories[j].Name};\r\nNote name: {notes[i].Name}; Record: {notes[i].Record};");
                        /*string filePath = notes[i].PhotoUrl;  pabaigti iterpti nuotraukas i pagrindini ekrana;
                        string name = notes[i].Name;
                        pictureImageList.Images.Add(name, new Bitmap(filePath));
                        imagPictureBox.Image = pictureImageList.Images[notes[i].Name];*/
                    }
                }                
            }
        }
        private void AddCategorieByUserToList(Guid userId)
         {   
            List<Categorie> categorieList = findData.FindCategorieByUserId(userId);
             for (int i = 0; i < categorieList.Count; i++)
             {
                 categorieListBox.Items.Add(categorieList[i].Name);
                 categorieNameList.Items.Add(categorieList[i].Name);
             }
         }
        private void AddNoteNameByUserToList(Guid userId)
        {
            noteNameList.Items.Clear();
            List<Note> noteList = findData.FindNotesByUser(userId);
            for (int i = 0; i < noteList.Count; i++)
            {
                noteNameList.Items.Add(noteList[i].Name);
            }
        }
        private void CreateNewCategorieButton_Click(object sender, System.EventArgs e)
        {
            string name = categorieNameTextBox.Text;
            Guid userId = Guid.Parse(userIdLabel.Text);
            var categorie = findData.FindCategorieByUserAndName(userId, name);
            if (categorie != null)
            {
                MessageBox.Show("This categorie allready exists. Please choose from the list below, or enter new one.");
            } else
            {
                string description = descriptionTextBox.Text;
                addData.AddNewCategorie(name, true, description, userId);
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
            {   var fileName = openFile.FileName;
                uploadPictureBox.Image = new Bitmap(fileName);
                imgFilePath.Text = fileName;
            }
        }
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            string name = noteNameTextBox.Text;
            Guid userId = Guid.Parse(userIdLabel.Text);
            var _note = findData.FindNoteByUserAndName(userId, name);
            if (_note != null)
            {
                MessageBox.Show("This note name allready exists.");
            }else
            {
                string record = noteTextBox.Text;
                var categorie = findData.FindCategorieByName(categorieNameList.Text);
                Guid categorieId = categorie.Id;
                string pictureFilePath = imgFilePath.Text;
                addData.AddNewNote(name, record, true, pictureFilePath, categorieId, userId);
                noteNameList.Items.Add(name);
                var user = findData.FindUserById(userId);
                var note = findData.FindNoteByName(name);
                addData.AddNoteToUser(user, note);
                addData.AddNoteToCategorie(categorie, note);
                noteListView.AppendText($"\r\nCategorie: {categorie.Name};\r\nNote name: {name}; Record: {record};\r\n");
                noteNameTextBox.Clear();
                noteTextBox.Clear();
                MessageBox.Show("Note created succsesfully");
            }            
        }
        private void searchNoteByNameButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            imgBox.Image = null;
            var note = findData.FindNoteByName(noteNameList.Text);
            searchTextBox.AppendText($"Name: {note.Name};\r\n Note: {note.Record}\r\n");
            idLabel.Text = note.Id.ToString();
            if (note.PhotoUrl == "")
            {
                imgBox.Visible = false;
            } else
            {
                imgBox.Image = new Bitmap(note.PhotoUrl);
            }
            noteNameList.Text = "Choose note name...";
        }
        private void searchNotesByCategorie_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            imgBox.Image = null;
            var notes = findData.FindNotesByCategorieName(categorieListBox.Text);
            if(notes.Count == 0)
            {
                searchTextBox.AppendText($"Categorie: {categorieListBox.Text} has no notes.");
                var categorie = findData.FindCategorieByName(categorieListBox.Text);
                idLabel.Text = categorie.Id.ToString();
            }
            else
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    searchTextBox.AppendText($"Categorie: {categorieListBox.Text};\r\n Notes names: {notes[i].Name}\r\n Records: {notes[i].Record}\r\n");
                    idLabel.Text = notes[i].CategorieId.ToString();
                }
                
            }           
            categorieListBox.Text = "Choose categorie name...";
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Guid idFromLabel = Guid.Parse(idLabel.Text);
            var categorie = findData.FindCategorieById(idFromLabel);
            var note = findData.FindNoteById(idFromLabel);
            if (note != null)
            {
                noteNameList.Items.Remove(note.Name);
                removeData.RemoveNote(note);
                searchTextBox.Clear();
                MessageBox.Show("Note deleted succsesfully.");
            }
            else
            {
                categorieListBox.Items.Remove(categorie.Name);
                categorieNameList.Items.Remove(categorie.Name);
                removeData.RemoveCategorie(categorie);
                searchTextBox.Clear();
                MessageBox.Show("Categorie deleted succsesfully.");
            }            
            this.Close();
            PrivateNoteForm privateNoteForm = new PrivateNoteForm();
            privateNoteForm.ShowDialog();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            SetValueForNoteOrCategorieId = idLabel.Text;
            Guid ID = Guid.Parse(idLabel.Text);
            SetValueForUserId = userIdLabel.Text;
            var note = findData.FindNoteById(ID);
            if (note != null)
            {
                NoteEditForm editNoteForm = new NoteEditForm();
                editNoteForm.ShowDialog();
            }
            else
            {
                CategorieEditForm categorieEditForm = new CategorieEditForm();
                categorieEditForm.ShowDialog();
            }
            
        }
    }
}
