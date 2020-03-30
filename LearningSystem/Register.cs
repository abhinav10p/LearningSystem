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
        private  List<TextBoxBase> txtBoxes;


        BaseController baseController;

       
        private bool checkValid;

        public Register()
        {
            InitializeComponent();

            baseController = new BaseController();

            txtBoxes = new List<TextBoxBase>(){
                firstNameBox,
                emailBox,
                paswordBox,
                retypePassword,
                contactBox,
                lastNameBox
            };
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Exit
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//NacToLogin
        {
            baseController.NavTo("Login");
        }

        private void sumitButton_Click(object sender, EventArgs e)
        {
            this.Submit_Data();
        }

        private void Submit_Data()
        {
            checkValid = true;

            this.CheckValidity(checkValid);

            if (checkValid)
            {
                var ins = baseController.GetStudentProfileByEmail(txtBoxes[1].Text);


                if (ins == null)
                {
                    baseController.InsertStudent(txtBoxes[0].Text, txtBoxes[5].Text,
                        txtBoxes[4].Text, txtBoxes[1].Text, txtBoxes[2].Text);

                    baseController.NavTo("Login");
                }
                else
                {
                    MessageBox.Show("User already exists");
                }
            }
        }

        private void CheckValidity(bool checkValid)
        {
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
        }

        private void Register_VisibleChanged(object sender, EventArgs e)
        {
            foreach (var item in txtBoxes)
            {
                item.Text = "";
            }
        }

        private void contactBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Submit_Data();
            }
        }
    }
}
