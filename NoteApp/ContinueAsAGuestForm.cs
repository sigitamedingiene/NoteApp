using System;
using System.Windows.Forms;
using NoteAppBusiness.Serivices;
using NoteAppRepository.Db_Content;

namespace NoteApp
{
    public partial class ContinueAsAGuestForm : Form
    { 
        public static DbContent _content = new();
        CategorieServices categorieServices = new(_content);
        UserServices userServices = new(_content);
        NoteServices noteServices = new(_content);

        public ContinueAsAGuestForm()
        {
            InitializeComponent();
            AddPublicUser();
        }
        public void AddPublicUser()
        {
            var user = userServices.FindUserByLogNameAndPassword("public", "public");
            if (user == null)
            {
                userServices.AddPublicUser();
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string categorieName = categorieNameTextBox.Text;
            string categorieDescription = categorieDescriptionTextBox.Text;
            string noteName = noteNameTextBox.Text;
            string note = noteTextBox.Text;
            var user = userServices.FindUserByLogNameAndPassword("public", "public");
            Guid userId = user.Id;
            if(categorieName == "" || categorieDescription == "" || noteName == "" || note == "")
            {
                MessageBox.Show("Please fill all the boxes.");
            }
            else
            {
                categorieServices.AddNewCategorie(categorieName, false, categorieDescription, userId);
                var categorie = categorieServices.FindPublicCategorieByName(categorieName);
                Guid categorieId = categorie.Id;
                noteServices.AddNewNote(noteName, note, false, "none", categorieId, userId);
                MessageBox.Show("Data added");
                infoTextBox.AppendText($"Categorie: {categorieName};\r\n Note name: {noteName}; Note: {note}\r\n\r\n");
                categorieNameTextBox.Clear();
                categorieDescriptionTextBox.Clear();
                noteNameTextBox.Clear();
                noteTextBox.Clear();
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string categorieName = categorieSearchTextBox.Text;
            var categorie = categorieServices.FindPublicCategorieByName(categorieName);
            if (categorieName == "")
            {
                MessageBox.Show("Please write the categorie name");
            }else if (categorie == null)
            {
                MessageBox.Show("No data found. Make sure you have entered the categorie name correctly.");
            }else
            {
                infoTextBox.AppendText($"Categorie: {categorie.Name};\r\n");
                var note = noteServices.FindNoteByCategorieId(categorie.Id);
                for (int i = 0; i < note.Count; i++)
                {
                    infoTextBox.AppendText($"Note name: {note[i].Name};\r\n Note: {note[i].Record}\r\n\r\n");
                }
            }
        }
    }
}
