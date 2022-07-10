using System.Collections.Generic;
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
            userId.Text = LogInForm.SetValueForUserId;
            userTextBox.Text = LogInForm.SetValueForUserName;
            userSurnameTextBox.Text = LogInForm.SetValueForUserSurName;
        }
        private void AddCategorieToList()
        {
            List<Categorie> categorieList = findData.FindAllCategories();
            for (int i = 0; i < categorieList.Count; i++)
            {
                categorieListBox.Items.Add(categorieList[i].Name);
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
                addData.AddNewCategorie(name, true, description);
                MessageBox.Show("Categorie created succsesfully.");
                categorieNameTextBox.Clear();
                descriptionTextBox.Clear();
                AddCategorieToList();
            }           
        }
    }
}
