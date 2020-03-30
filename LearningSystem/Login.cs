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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Login_Action();
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

        private void Login_Action()
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

            if (UserType == 0)
            {
                radioButton1.Focus();

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
 
                        BaseController.SetUserId(ins.StudentId);

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

        private void ResetAll_Click(object sender, EventArgs e)
        {
            foreach (var item in txtBoxes)
            {
                item.Text = "";
            }
            statusLabel.Text = "";
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BaseController.NavTo("Register");
        }

        private void passBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login_Action();
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BaseController.NavTo("MainBoard");
        }
    }
}
