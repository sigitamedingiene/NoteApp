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
        }
        public static DbContent _content = new();
        UserServices findData = new(_content);
        SignUpForm signUp = new();
        PrivateNoteForm privateForm = new();
        public static string SetValueForUserId = "";
        public static string SetValueForUserName = "";
        public static string SetValueForUserSurName = "";
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
                SetValueForUserId = user.Id.ToString();
                SetValueForUserName = user.Name;
                SetValueForUserSurName = user.SurName;
                privateForm.Show();
                this.Visible = false;
            }   
        }
        private void ContinueAsAGuestButton_Click(object sender, System.EventArgs e)
        {
            ContinueAsAGuestForm guestForm = new();
            guestForm.Show();
        }
    }
}
