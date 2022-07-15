using System;
using System.Windows.Forms;
using NoteAppBusiness.Serivices;
using NoteAppRepository.Db_Content;

namespace NoteApp
{
    public partial class CategorieEditForm : Form
    {
        public static DbContent _content = new();
        FindDataInDataBase findData = new FindDataInDataBase(_content);
        EditDataInDataBase editData = new EditDataInDataBase(_content);
        public CategorieEditForm()
        {
            InitializeComponent();
        }
        private void CategorieEditForm_Load(object sender, System.EventArgs e)
        {
            categorieIdLabel.Text = PrivateNoteForm.SetValueForNoteOrCategorieId;
            userIdLabel.Text = PrivateNoteForm.SetValueForUserId;
            FindAndShowData();
        }
        private void FindAndShowData()
        {
            Guid categorieId = Guid.Parse(categorieIdLabel.Text);
            var categorie = findData.FindCategorieById(categorieId);
            nameTextBox.Text = categorie.Name;
            descriptionTextBox.Text = categorie.Description;           
        }
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            Guid categorieId = Guid.Parse(categorieIdLabel.Text);
            var categorie = findData.FindCategorieById(categorieId);
            Guid userId = Guid.Parse(userIdLabel.Text);
            categorie.Name = nameTextBox.Text;
            categorie.Description = descriptionTextBox.Text;
            editData.EditCategorie(categorieId, categorie);
            ShowMessageBox();
        }
        private void ShowMessageBox()
        {
            string message = "To save your changes, we need to restart this program";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Continue editing");
            }
        }
    }
}
