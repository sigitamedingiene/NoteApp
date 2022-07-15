using System;
using System.Drawing;
using System.Windows.Forms;
using NoteAppBusiness.Serivices;
using NoteAppRepository.Db_Content;


namespace NoteApp
{
    public partial class NoteEditForm : Form
    {
        public static DbContent _content = new();
        FindDataInDataBase findData = new FindDataInDataBase(_content);
        EditDataInDataBase editData = new EditDataInDataBase(_content);
        public NoteEditForm()
        {
            InitializeComponent();
        }
        private void NoteEditForm_Load(object sender, EventArgs e)
        {
            noteIdLabel.Text = PrivateNoteForm.SetValueForNoteOrCategorieId;
            userIdLabel.Text = PrivateNoteForm.SetValueForUserId;
            FindAndShowData();
        }
        private void FindAndShowData()
        {
            Guid noteId = Guid.Parse(noteIdLabel.Text);
            var note = findData.FindNoteById(noteId);
            nameTextBox.Text = note.Name;
            recordTextBox.Text = note.Record;
            if(note.PhotoUrl != "")
            {
                photoBox.Image = new Bitmap(note.PhotoUrl);
                filePathLabel.Text = note.PhotoUrl;
            }            
        }
        private void uploadNewPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jepg;.*.gif;) |*.jpg;*.jepg;.*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFile.FileName;
                photoBox.Image = new Bitmap(fileName);
                filePathLabel.Text = fileName;
            }
        }
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            Guid noteId = Guid.Parse(noteIdLabel.Text);
            var note = findData.FindNoteById(noteId);
            Guid userId = Guid.Parse(userIdLabel.Text);
            note.Name = nameTextBox.Text;
            note.Record = recordTextBox.Text;
            note.PhotoUrl = filePathLabel.Text;
            editData.EditNote(noteId, note);
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
