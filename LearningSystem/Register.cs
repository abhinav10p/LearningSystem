using LearningSystem.Controller;
using LearningSystem.Model;
using LearningSystem.Model.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSystem
{
    public partial class Register : Form
    {
        private List<TextBoxBase> txtBoxes;
        public Register()
        {
            InitializeComponent();
            txtBoxes = new List<TextBoxBase>(){
                firstNameBox,
                emailBox,
                paswordBox,
                retypePassword,
                contactBox,
                lastNameBox
            };
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseController.NavTo("Login");
        }

        private void passCheck()
        {

        }
        private void sumitButton_Click(object sender, EventArgs e)
        {

            var checkValid = true;

            for (int i = 0; i < txtBoxes.Count; i++)
            {
                if (string.IsNullOrEmpty(txtBoxes[i].Text) && i < 4)
                {
                    checkValid = false;
                    errorProvider1.SetError(txtBoxes[i], "Please fill in the fields");
                    if (i == 2 || i == 3)
                    {
                        if (txtBoxes[2].Text != txtBoxes[3].Text)
                        {
                            errorProvider1.SetError(txtBoxes[i], "Password does not match");
                        }
                    }
                }
                else
                {
                    errorProvider1.SetError(txtBoxes[i], null);
                }
            }


            if (checkValid)
            {
                var ins = BaseController.GetStudentProfileByEmail(txtBoxes[1].Text);


                if (ins == null)
                {
                    BaseController.InsertStudent(txtBoxes[0].Text, txtBoxes[5].Text,
                        txtBoxes[4].Text, txtBoxes[1].Text, txtBoxes[2].Text);
                    BaseController.NavTo("Login");
                }
                else
                {
                    MessageBox.Show("User already exists");
                }
            }

        }

        private void emailBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Box_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
