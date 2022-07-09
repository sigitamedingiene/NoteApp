
using System.Windows.Forms;

namespace NoteApp
{
    public partial class LogInForm : Form
    {   
        public LogInForm()
        {
            InitializeComponent();
        }
        SignUpForm signUp = new SignUpForm();
        private void signUpButton_Click(object sender, System.EventArgs e)
        {
            signUp.ShowDialog();
        }
    }
}
