using LearningSystem.Controller;
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
    public partial class Mock : Form
    {
        BaseController baseController;
        public Mock()
        {
            baseController = new BaseController();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//CreateStudentMock
        {
            baseController.CreateStudentMock();
        }

        private void button2_Click(object sender, EventArgs e)//CreateCategory
        {
            baseController.CreateCategory();
        }

        private void button3_Click(object sender, EventArgs e)//CreateCourseMock
        {
            baseController.CreateCourseMock();
        }

        private void button4_Click(object sender, EventArgs e)//NavToLogin
        {
            baseController.NavTo("Login");
        }
    }
}
