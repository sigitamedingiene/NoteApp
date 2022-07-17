using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteAppBusiness.Serivices;
using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteApp
{
    public partial class SignUpForm : Form
    {
        public static DbContent _content = new DbContent();
        AddDataToDataBase addData = new(_content);
        FindDataInDataBase findData = new(_content);
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void createNewUserButton_Click(object sender, EventArgs e)
        {  
            string name = nameTextBox.Text;
            string surName = surNameTextBox.Text;
            string logInName = logInNameTextBox.Text;
            string logInPassword = passwordTextBox.Text;
            if (name == "" || surName == "" || logInName == "" || logInPassword == "")
            {
                MessageBox.Show("Please fill in all the boxes");
            }
            else
            {
                List<User> userLogInNames = findData.FindUserByLogInName(logInName);
                if (userLogInNames.Count == 0)
                {
                    addData.AddNewUser(name, surName, logInName, logInPassword);
                    MessageBox.Show("Account created succsesfully");
                    nameTextBox.Clear();
                    surNameTextBox.Clear();
                    logInNameTextBox.Clear();
                    passwordTextBox.Clear();
                }
                else
                {
                    logInNameTextBox.Clear();
                    MessageBox.Show("This user name is taken, please enter new one and try again.");
                }
            }          
        }
    }
}
