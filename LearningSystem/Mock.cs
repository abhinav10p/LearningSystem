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
        public Mock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseController.CreateStudentMock();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseController.CreateCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaseController.CreateCourseMock();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseController.NavTo("Login");
        }
    }
}
