using LearningSystem.Model;
using LearningSystem.Model.DB;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LearningSystem.Controller
{
    public class BaseController
    {
        private static int userid;
        public static int UserId { get { return userid; } set { userid = value; } }
        public BaseController()
        {

        }

        public static List<Student> GetStudents()
        {
            DBData db = DBData.Instance;
            return db.context.Students.ToList();
        }

        public static StudentProfile GetStudentProfileById(string sId)
        {
            DBData db = DBData.Instance;
            return db.context.StudentProfiles.ToList().SingleOrDefault(p => p.StudentId == int.Parse(sId));
        }

        public static StudentProfile GetStudentProfileByEmail(string sId)
        {
            DBData db = DBData.Instance;
            return db.context.StudentProfiles.ToList().SingleOrDefault(p => p.Email == sId);
        }

        public static List<Topic> GetTopics(string sId)
        {
            DBData db = DBData.Instance;
            return db.context.Topics
                .ToList().Where(p => p.CourseId == int.Parse(sId)).ToList();
        }

        public static List<Course> GetCourses()
        {
            DBData db = DBData.Instance;
            return db.context.Courses
                .Include(c => c.Topics)
                .ToList();
        }

        public static void CreateStudentMock()
        {
            DBData db = DBData.Instance;
            db.CreateStudentMock();
        }

        public static void CreateCourseMock()
        {
            DBData db = DBData.Instance;
            db.CreateCourseMock();
        }

        public static void CreateCategory()
        {
            DBData db = DBData.Instance;
            db.CreateCategory();
        }


        public static void NavTo(string windowName)
        {
            var notFound = true;

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {
                    Application.OpenForms[i].Show();
                    notFound = false;
                }
                else
                {
                    Application.OpenForms[i].Hide();
                }
            }

            if (notFound)
            {
                IfwindowNoFound(windowName);
            }
        }
        private static void IfwindowNoFound(string windowName)
        {
            switch (windowName)
            {
                case "Login":
                    new Login().Show();
                    break;
                case "Register":
                    new Register().Show();
                    break;
                case "MainBoard":
                    new MainBoard().Show();
                    break;
                case "Mock":
                    new Mock().Show();
                    break;
            }
        }

        public static void InsertStudent(string p1, string p2, string p3, string p4, string p5)
        {
            Student student = new Student()
            {
                FirstName = p1,
                LastName = p2,
                StudentProfile = new StudentProfile
                {
                    Contact = p3,
                    Email = p4,
                    Password = p5
                }
            };
            DBData db = DBData.Instance;

            db.context.Students.Add(student);

            db.context.SaveChanges();
        }

        #region
        /* public static Form GetLogin()
         {
             DBData db = DBData.Instance;
             return db.GetLogin();
         }

         public Form GetRegister()
         {
             DBData db = DBData.Instance;
             return db.GetRegister();
         }

         public Form GetMainBoard()
         {
             DBData db = DBData.Instance;
             return db.GetMainBoard();
         }*/
        #endregion

    }
}
