using System.Windows.Forms;
using NoteAppBusiness.Serivices;
using NoteAppRepository.Db_Content;

namespace NoteApp
{
    public partial class LogInForm : Form
    {   
        public LogInForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }
        public static DbContent _content = new();
        FindDataInDataBase findData = new(_content);
        SignUpForm signUp = new SignUpForm();
        PrivateNoteForm privateForm = new PrivateNoteForm();

        private void signUpButton_Click(object sender, System.EventArgs e)
        {
            signUp.ShowDialog();
        }
        private void signInButton_Click(object sender, System.EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string userPassword = passwordTextBox.Text;            
            var user = findData.FindUserByLogNameAndPassword(userName, userPassword);
            if (user == null)
            {
                MessageBox.Show("User name or password is incorrect.");
                userNameTextBox.Clear();
                passwordTextBox.Clear();
            } else
            {
                privateForm.Show();
                this.Visible = false;
            }            
        }
    }
}
