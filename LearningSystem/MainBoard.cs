using LearningSystem.Controller;
using LearningSystem.Model;
using LearningSystem.Model.DB;
using LearningSystem.UXCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LearningSystem
{
    public partial class MainBoard : Form
    {
        private readonly DBData Mock;
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();

        public MainBoard()
        {
            InitializeComponent();
            Mock = DBData.Instance;
            LoadItems();
        }


        private void Menu_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;

            switch (int.Parse(menuItem.Tag.ToString()))
            {
                case 0:
                    Application.Exit();
                    break;
                case 1:
                    BaseController.CreateStudentMock();
                    break;
                case 2:
                    BaseController.CreateCourseMock();
                    break;
                case 3:
                    BaseController.CreateCategory();
                    break;
                case 4:
                    BaseController.NavTo("Login");
                    break;
            }
        }

        private void Load_Courses(object sender, EventArgs e)
        {
            this.courses = BaseController.GetCourses();
            if (this.courses.Count != 0)
            {
                courseListBox.DataSource = this.courses;
                courseListBox.DisplayMember = "Name";
                courseListBox.ValueMember = "Id";
                courseListBox.SetSelected(0, true);
                this.ShowSelectedCourseData();
            }
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            this.students = BaseController.GetStudents();
            if (this.students.Count != 0)
            {
                listBox1.DataSource = this.students;
                listBox1.DisplayMember = "FirstName";
                listBox1.ValueMember = "Id";
                listBox1.SetSelected(0, true);
                this.ShowSelectData();
            }

        }


        private void UserListItem_Click(object sender, EventArgs e)
        {
            this.ShowSelectData();
        }

        private void CourseListItem_Click(object sender, EventArgs e)
        {
            this.ShowSelectedCourseData();
        }

        private void ShowSelectedCourseData()
        {
            var sId = courseListBox.SelectedValue.ToString();

            if (sId != null)
            {
                var courseDetails = this.courses[int.Parse(sId) - 1].Topics;

                if (courseDetails.Count() > 0)
                {
                    dataGridView1.DataSource = courseDetails.ToList();
                    dataGridView1.Columns["CourseId"].Visible = false;
                    dataGridView1.Columns["Course"].Visible = false;
                    dataGridView1.Columns["Progresses"].Visible = false;
                    dataGridView1.Columns["Id"].Visible = false;
                }
            }
        }

        private void ShowSelectData()
        {
            var sId = listBox1.SelectedValue;

            if (sId != null)
            {
                var studentProfiles = BaseController.GetStudentProfileById(sId.ToString());
                textBox1.Text = this.students[listBox1.SelectedIndex].FirstName;
                textBox2.Text = this.students[listBox1.SelectedIndex].LastName;
                textBox3.Text = studentProfiles.Contact;
                textBox4.Text = studentProfiles.Email;
            }
        }


        private void LoadItems()
        {
            CustomListItem[] customListItem = new CustomListItem[20];

            for (int i = 0; i < 20; i++)
            {
                customListItem[i] = new CustomListItem();
                customListItem[i].Title = $"Hello{i.ToString()}";
                customListItem[i].MouseDown += new MouseEventHandler(this.CustomItem_Click);
                flowLayoutPanel1.Controls.Add(customListItem[i]);
            }
        }

        private void CustomItem_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello");
        }


    }
}

