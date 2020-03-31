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

        BaseController baseController;
        public Login()
        {
            InitializeComponent();

            baseController = new BaseController();

            txtBoxes = new List<TextBoxBase>(){
               userBox,
               passBox
            };
        }

        private void loginButton_Click(object sender, EventArgs e)//Login Click
        {
            this.Login_Action();
        }

        private void User_Checked(object sender, EventArgs e)//User Type
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

        private void Login_Action()//Login Action
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
                if (txtBoxes[1].Text == null || txtBoxes[1].Text == "")
                {
                    errorProvider1.SetError(txtBoxes[1], "Please check your password");
                    statusLabel.Text = "Please check your password";
                    return;
                }
                var ins = baseController.GetStudentProfileByEmail(txtBoxes[0].Text, txtBoxes[1].Text);

                if (ins != null)
                {
                    if (ins.Password)
                    {
                        baseController.SetUserId(ins.StudentId);
                        baseController.SetUserInfo(ins.Name);
                        baseController.NavTo("MainBoard");                   

                        statusLabel.Text = $"Welcome your are logged in successfully";
                    }
                    else
                    {
                        statusLabel.Text = "Check you credentials";
                        txtBoxes[0].Text = txtBoxes[1].Text = "";
                    }
                }
                else
                {
                    statusLabel.Text = "User doesnot exists";
                    txtBoxes[0].Text = txtBoxes[1].Text = "";
                }
            }
        }

        private void ResetAll_Click(object sender, EventArgs e)//Reset Fields
        {
            foreach (var item in txtBoxes)
            {
                item.Text = "";
            }
            statusLabel.Text = "";
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Register
        {
            baseController.NavTo("Register");
        }

        private void passBox_KeyDown(object sender, KeyEventArgs e)//Pass Action
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login_Action();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Exit
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Demo
        {
            baseController.NavTo("MainBoard");
        }
    }
}
