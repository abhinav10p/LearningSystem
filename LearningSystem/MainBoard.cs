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
        BaseController baseController;

        List<Student> students;
        List<Course> courses;
        List<Topic> topics;
        List<FullProgress> progresses;

        public MainBoard()
        {
            InitializeComponent();

            baseController = new BaseController();
            students = new List<Student>();
            courses = new List<Course>();
            topics = new List<Topic>();
            progresses = new List<FullProgress>();

            Oninit();
        }


        private void Oninit()
        {

            baseController.SetUserId(2);

            courses = baseController.GetCourses();

            GetCourses(0);

            comboCategories.DataSource = baseController.GetCategories();
        }


        private void GetProgress(int u, DataGridView grid)
        {
            int i;
            i = (u == 0) ? 0 : 1;

            progresses = baseController.GetProgress(i);

            grid.DataSource = progresses;
            grid.Columns["CourseId"].Visible = false;
            grid.Columns["TopicId"].Visible = false;
            grid.Columns["StudentId"].Visible = false;
            grid.Columns["Id"].Visible = false;
            grid.Columns["Name"].Visible = (u != 0);
        }


        // Courses
        private void GetCourses(int u, [Optional]int isFiltered, [Optional]int param)
        {
            if (courses.Count != 0 || progresses.Count != 0)
            {
                if (u == 0)
                {
                    courseList.DataSource = (isFiltered == 0) ? courses : courses.Where(c => c.Id == param).ToList();
                    courseList.SetSelected(0, true);

                    //this.GetSelectedTopics(topicList, 0, (int)courseList.SelectedValue);
                    this.GetSelectedCustomTopics((int)courseList.SelectedValue);
                }
                else
                {
                    courseList2.DataSource = progresses;

                    if (courseList2.Items.Count > 0)
                    {
                        courseList2.SetSelected(0, true);
                        this.GetSelectedTopics(topicList2, 1, (int)courseList2.SelectedValue);
                    }
                    else
                    {
                        courseList2.DataSource = null;
                    }
                }
            }
        }

        private void CourseListItem_Click(object sender, EventArgs e)
        {
            this.GetSelectedCustomTopics((int)courseList.SelectedValue);
        }

        private void CourseList2_Click(object sender, EventArgs e)
        {
            this.GetSelectedTopics(topicList2, 1, (int)courseList2.SelectedValue);
        }

        private void GetSelectedCustomTopics(int index)
        {
            var sId = index - 1;

            if (sId != -1)
            {
                var courseDetails = courses[sId].Topics;
                topics = courseDetails.ToList();

                if (courseDetails.Count() > 0)
                {
                    var count = topics.Count();

                    CustomListItem[] customListItem = new CustomListItem[count];

                    customTopicList.Controls.Clear();

                    for (int i = 0; i < count; i++)
                    {
                        customListItem[i] = new CustomListItem();
                        customListItem[i].Title = topics[i].Name;
                        customListItem[i].Width = 300;
                        customListItem[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)))));

                        customTopicList.Controls.Add(customListItem[i]);
                    }
                }
            }
            authorTxt.Text = courses[sId].Teacher.TeacherProfile.FirstName +
                    courses[sId].Teacher.TeacherProfile.LastName;
            detailTxt.Text = courses[sId].Description;
            hoursTxt.Text = courses[sId].TotalHours.ToString();
            lecturesTxt.Text = courses[sId].Lectures.ToString();
        }

        private void GetSelectedTopics(ListBox list, int u, int index)
        {
            var sId = index - 1;

            if (sId != -1)
            {
                var courseDetails = courses[sId].Topics;
                topics = courseDetails.ToList();

                list.DataSource = (courseDetails.Count() > 0 && topics.Count() > 0) ? topics : null;
                if (u == 0)
                {
                    authorTxt.Text = courses[sId].Teacher.TeacherProfile.FirstName +
                    courses[sId].Teacher.TeacherProfile.LastName;
                    detailTxt.Text = courses[sId].Description;
                    hoursTxt.Text = courses[sId].TotalHours.ToString();
                    lecturesTxt.Text = courses[sId].Lectures.ToString();
                }
            }
        }



        private void EnrollButton_Click(object sender, EventArgs e) //Enroll
        {
            var sId = courseList.SelectedValue.ToString();
            var message = baseController.InsertProgress(sId);

            mainStatus.Text = message;
        }

        private void LearnButton_Click(object sender, EventArgs e)  //Learn
        {
            var selectedId = topicList2.SelectedIndex;
            var cId = topics[selectedId].CourseId;
            var message = "";
            int index = progresses.FindIndex(c => c.CourseId == cId);

            if (index != -1)
            {
                var tId = progresses[index].TopicId;
                message = baseController.UpdateProgress(topics[selectedId].Id, tId, index);
            }

            mainStatus.Text = message;

            GetProgress(0, progressGrid);
        }






        //Student 
        private void LoadCustomList()
        {
            students = baseController.GetStudents();

            var count = students.Count();

            CustomListItem[] customListItem = new CustomListItem[count];

            userList.Controls.Clear();

            for (int i = 0; i < count; i++)
            {
                customListItem[i] = new CustomListItem();
                customListItem[i].Title = students[i].FirstName + " " + students[i].LastName;
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
            var studentProfiles = baseController.GetStudentProfileById(sId.ToString());

            textBox1.Text = students[sId - 1].FirstName;
            textBox2.Text = students[sId - 1].LastName;
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



        // Page Tab Select
        private void pageTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pageTab.SelectedIndex)
            {

                case 0:
                    GetCourses(0);
                    break;

                case 1:
                    GetProgress(0, progressGrid);
                    progresses = baseController.GetProgress(0);
                    GetCourses(1);
                    break;

                case 2:
                    LoadCustomList();
                    GetProgress(1, userProgress);
                    break;
            }
        }


        // Combo Category
        private void comboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sId = ((ComboBox)sender).SelectedIndex;

            GetCourses(0, (sId != 0) ? 1 : 0, sId);
        }


        //Menu
        private void Menu_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;

            switch (int.Parse(menuItem.Tag.ToString()))
            {
                case 0:
                    Application.Exit();
                    break;
                case 4:
                    baseController.NavTo("Login");
                    break;
            }
        }
    }
}

