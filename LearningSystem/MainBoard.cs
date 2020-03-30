using LearningSystem.Controller;
using LearningSystem.Model;
using LearningSystem.Model.API;
using LearningSystem.Model.DB;
using LearningSystem.UXCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LearningSystem
{
    public partial class MainBoard : Form
    {
        private readonly DBData Mock;

        List<Student> students = new List<Student>();

        List<Course> courses = new List<Course>();

        List<Topic> topics = new List<Topic>();
        
        List<FullProgress> progresses = new List<FullProgress>();

        public MainBoard()
        {
            InitializeComponent();

            Mock = DBData.Instance;

            Oninit();
        }


        private void Oninit()
        {
            
            BaseController.SetUserId(2);

            this.courses = BaseController.GetCourses();

            GetCourses(courseList, 0);

            comboCategories.DataSource = BaseController.GetCategories();
            comboCategories.DisplayMember = "Category";
            comboCategories.ValueMember = "CourseId";

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;

            switch (int.Parse(menuItem.Tag.ToString()))
            {
                case 0:
                    Application.Exit();
                    break;
                case 4:
                    BaseController.NavTo("Login");
                    break;
            }
        }




        private void CourseListItem_Click(object sender, EventArgs e)
        {
            this.GetSelectedTopics(topicList, 0, (int)courseList.SelectedValue);
        }
        private void GetSelectedTopics(ListBox list, int u, int index)
        {
            var sId = index - 1;

            if (sId != -1)
            {
                var courseDetails = this.courses[sId].Topics;
                this.topics = courseDetails.ToList();

                if (courseDetails.Count() > 0)
                {
                    list.DataSource = this.topics;
                    list.DisplayMember = "Name";
                    list.ValueMember = "Id";
                }

                if (u == 0)
                {
                    authorTxt.Text = this.courses[sId].Teacher.TeacherProfile.FirstName +
                    this.courses[sId].Teacher.TeacherProfile.LastName;
                    detailTxt.Text = this.courses[sId].Description;
                    hoursTxt.Text = this.courses[sId].TotalHours.ToString();
                    lecturesTxt.Text = this.courses[sId].Lectures.ToString();
                }
            }
        }

        private void courseList2_Click(object sender, EventArgs e)
        {
            this.GetSelectedTopics(topicList2, 1, (int)courseList2.SelectedValue);
        }

        private void LoadCustomList()
        {
            this.students = BaseController.GetStudents();

            var count = this.students.Count();

            CustomListItem[] customListItem = new CustomListItem[count];

            userList.Controls.Clear();

            for (int i = 0; i < count - 1; i++)
            {
                customListItem[i] = new CustomListItem();
                customListItem[i].Title = this.students[i].FirstName + " " + this.students[i].LastName;
                customListItem[i].MouseDown += new MouseEventHandler(this.CustomItem_Click);
                customListItem[i].Controls[0].MouseDown += new MouseEventHandler(this.CustomLabel_Click);
                customListItem[i].Tag = i;
                customListItem[i].Width = userList.Width - 6;
                customListItem[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)))));
               
                userList.Controls.Add(customListItem[i]);
            }


        }
        private void SetStudentDetails(int sId)
        {
            var studentProfiles = BaseController.GetStudentProfileById(sId.ToString());

            textBox1.Text = this.students[sId - 1].FirstName;
            textBox2.Text = this.students[sId - 1].LastName;
            textBox3.Text = studentProfiles.Contact;
            textBox4.Text = studentProfiles.Email;
        }
        private void CustomItem_Click(object sender, MouseEventArgs e)
        {
            int sId = (int)((CustomListItem)sender).Tag + 1;

            this.SetStudentDetails(sId);
        }
        private void CustomLabel_Click(object sender, MouseEventArgs e)
        {
            int sId = (int)((Label)sender).Parent.Tag + 1;

            this.SetStudentDetails(sId);
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            var sId = courseList.SelectedValue.ToString();

            var message = BaseController.InsertProgress(sId);
            mainStatus.Text = message;
        }

        private void LearnButton_Click(object sender, EventArgs e)
        {
            var selectedId = topicList2.SelectedIndex;
            var cId = this.topics[selectedId].CourseId;
            var message = "";
            int index = this.progresses.FindIndex(c => c.CourseId == cId);

            if (index != -1)
            {
                var tId = this.progresses[index].TopicId;
                message = BaseController.UpdateProgress(this.topics[selectedId].Id, tId, index);
            }

            mainStatus.Text = message;

            GetProgress(0, progressGrid);
        }


        private void GetProgress(int u, DataGridView grid)
        {
            int i;
            i = (u == 0) ? 0 : 1;

            this.progresses = BaseController.GetProgress(i);

            grid.DataSource = this.progresses;
            grid.Columns["CourseId"].Visible = false;
            grid.Columns["TopicId"].Visible = false;
            grid.Columns["StudentId"].Visible = false;
            grid.Columns["Id"].Visible = false;
            grid.Columns["Name"].Visible = (u != 0);
        }

        private void GetCourses(ListBox list, int u, [Optional]int f, [Optional]int p)
        {
            if (this.courses.Count != 0 || this.progresses.Count != 0)
            {
                if (u == 0)
                {
                    list.DataSource = (f == 0) ? this.courses : this.courses.Where(c => c.Id == p).ToList();
                    list.ValueMember = "Id";
                    list.DisplayMember = "Name";
                    if ((f == 0))
                        list.SetSelected(0, true);

                    this.GetSelectedTopics(topicList, 0, (int)courseList.SelectedValue);
                }
                else
                {
                    list.DisplayMember = "Course";
                    list.ValueMember = "CourseId";
                    list.DataSource = this.progresses;
                    list.SetSelected(0, true);

                    this.GetSelectedTopics(topicList2, 1, (int)courseList2.SelectedValue);
                }
            }
        }

        private void pageTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pageTab.SelectedIndex)
            {

                case 0:
                    GetCourses(courseList, 0);
                    break;

                case 1:
                    GetProgress(0, progressGrid);
                    this.progresses = BaseController.GetProgress(0);
                    GetCourses(courseList2, 1);
                    break;

                case 2:
                    LoadCustomList();
                    GetProgress(1, userProgress);
                    break;
            }
        }

        private void comboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sId = ((ComboBox)sender).SelectedIndex;

            if(sId != 0)
            {
                GetCourses(courseList2, 0, 1, sId);
            }
            
        }
    }
}

