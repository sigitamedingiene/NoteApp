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
            userTextBox.AppendText($"{LogInForm.SetValueForUserName} {LogInForm.SetValueForUserSurName}");
            Guid userId = Guid.Parse(userIdLabel.Text);
            AddNoteNameByUserToList(userId);
            AddCategorieByUserToList(userId);
            var notes = findData.FindNotesByUser(userId);
            var categories = findData.FindCategorieByUserId(userId);
            for (int i = 0; i < notes.Count; i++)
            {
                for (int j = 0; j < categories.Count; j++)
                {
                    if (notes[i].CategorieId == categories[j].Id)
                    {
                        if (notes[i].PhotoUrl == null)
                        {
                            noteListView.AppendText($"Categorie: {categories[j].Name}\r\nNote name: {notes[i].Name}\r\nRecord: {notes[i].Record}\r\n\r\n");
                        }
                        noteListView.AppendText($"Categorie: {categories[j].Name}\r\nNote name: {notes[i].Name}\r\nRecord: {notes[i].Record}\r\n\r\n");
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
            string description = descriptionTextBox.Text;
            Guid userId = Guid.Parse(userIdLabel.Text);
            if(name == "" || description == "")
            {
                MessageBox.Show("Please fill in all the boxes");
            }
            else
            {
                var categorie = findData.FindCategorieByUserAndName(userId, name);
                if (categorie != null)
                {
                    MessageBox.Show("This categorie allready exists. Please choose from the list below, or enter a new one.");
                }
                else
                {
                    addData.AddNewCategorie(name, true, description, userId);
                    categorieNameList.Items.Add(name);
                    categorieListBox.Items.Add(name);
                    MessageBox.Show("Categorie created succsesfully.");
                    categorieNameTextBox.Clear();
                    descriptionTextBox.Clear();
                }
            }            
        }
        private void uploadPhoto_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jepg;.*.gif;) |*.jpg;*.jepg;.*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFile.FileName;
                uploadPictureBox.Image = new Bitmap(fileName);
                imgFilePath.Text = fileName;
            }
        }
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            string name = noteNameTextBox.Text;
            string record = noteTextBox.Text;
            if(name == "" || record == "")
            {
                MessageBox.Show("Please fill in all the boxes.");
            } else if (categorieNameList.Text == "")
            {
                MessageBox.Show("Please choose categorie");
            } else
            {
                Guid userId = Guid.Parse(userIdLabel.Text);
                var _note = findData.FindNoteByUserAndName(userId, name);
                if (_note != null)
                {
                    MessageBox.Show("This note name allready exists.");
                }
                else
                {
                    var categorie = findData.FindCategorieByName(categorieNameList.Text);
                    Guid categorieId = categorie.Id;
                    string pictureFilePath = imgFilePath.Text;
                    addData.AddNewNote(name, record, true, pictureFilePath, categorieId, userId);
                    noteNameList.Items.Add(name);
                    var user = findData.FindUserById(userId);
                    var note = findData.FindNoteByName(name);
                    addData.AddNoteToUser(user, note);
                    addData.AddNoteToCategorie(categorie, note);
                    noteListView.AppendText($"Categorie: {categorie.Name}\r\nNote name: {name}\r\nRecord: {record}\r\n\r\n");
                    noteNameTextBox.Clear();
                    noteTextBox.Clear();
                    MessageBox.Show("Note created succsesfully");
                }
            }           
        }
        private void searchNoteByNameButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            imgBox.Image = null;
            string noteName = noteNameList.Text;
            if (noteName == "")
            {
                MessageBox.Show("Choose note name.");
            }
            else
            {
                var note = findData.FindNoteByName(noteName);
                searchTextBox.AppendText($"Name: {note.Name}\r\n Note: {note.Record}\r\n");
                idLabel.Text = note.Id.ToString();
                if (note.PhotoUrl == "")
                {
                    imgBox.Visible = false;
                }
                else
                {
                    imgBox.Image = new Bitmap(note.PhotoUrl);
                }
            }    
        }
        private void searchNotesByCategorie_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            imgBox.Image = null;
            string categorieName = categorieListBox.Text;
            if(categorieName == "")
            {
                MessageBox.Show("Please choose categorie.");
            }
            else
            {
                var notes = findData.FindNotesByCategorieName(categorieName);
                if (notes.Count == 0)
                {
                    searchTextBox.AppendText($"Categorie: {categorieListBox.Text} has no notes.");
                    var categorie = findData.FindCategorieByName(categorieListBox.Text);
                    idLabel.Text = categorie.Id.ToString();
                }
                else
                {
                    searchTextBox.AppendText($"Categorie: {categorieListBox.Text}:\r\n");
                    for (int i = 0; i < notes.Count; i++)
                    {
                        searchTextBox.AppendText($"Note name: {notes[i].Name};\r\nRecord: {notes[i].Record};\r\n\r\n");
                        idLabel.Text = notes[i].CategorieId.ToString();
                    }
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {   if(searchTextBox.Text == "")
            {
                MessageBox.Show("Please select what you want to delete.");
            }
            else
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
        }
        private void editButton_Click(object sender, EventArgs e)
        {   if(searchTextBox.Text == "")
            {
                MessageBox.Show("Please select what you want to edit.");
            }
            else
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
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }
    }
}
