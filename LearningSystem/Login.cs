using LearningSystem.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LearningSystem
{

    public partial class Login : Form
    {
        private List<TextBoxBase> txtBoxes;
        private int UserType = 0;
        public Login()
        {
            InitializeComponent();
            txtBoxes = new List<TextBoxBase>(){
               userBox,
               passBox
            };
           /* if(BaseController.GetStudents().Count == 0)
            {
                BaseController.NavTo("Mock");
                this.Hide();
            }*/
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var checkValid = true;

            for (int i = 0; i < txtBoxes.Count; i++)
            {
                if (string.IsNullOrEmpty(txtBoxes[i].Text))
                {
                    checkValid = false;
                    errorProvider1.SetError(txtBoxes[i], "Please fill in the fields");
                }
                else
                {
                    errorProvider1.SetError(txtBoxes[i], null);
                }
            }

            if(UserType == 0)
            {
                statusLabel.Text = "Select User Type";
                return;
            }

            if (checkValid)
            {

                var ins = BaseController.GetStudentProfileByEmail(txtBoxes[0].Text);

                if (ins != null)
                {
                    if (ins.Password == txtBoxes[1].Text)
                    {
                        BaseController.NavTo("MainBoard");
                        statusLabel.Text = $"Welcome your are logged in successfully";
                    }
                    else
                    {
                        errorProvider1.SetError(txtBoxes[1], "Please check your password");
                        statusLabel.Text = "Please check your password";
                    }
                }
                else
                {
                    statusLabel.Text = "User doesnot exists";
                    txtBoxes[0].Text = "";
                    txtBoxes[1].Text = "";
                }
            }

        }

        private void User_Checked(object sender, EventArgs e)
        {
            var userType = (RadioButton)sender;
            switch (userType.Tag.ToString())
            {
                case "1":
                    UserType = 1;
                    break;
                case "2":
                    UserType = 2;
                    break;

            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BaseController.NavTo("Register");
        }
    }
}
