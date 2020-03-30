using LearningSystem.Model;
using LearningSystem.Model.API;
using LearningSystem.Model.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LearningSystem.Controller
{
    public class BaseController
    {
      

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

        public static List<Model.API.CourseCategory> GetCategories()
        {
            DBData db = DBData.Instance;
            var cs = db.context.Courses;
            var cts = db.context.Categories;
            var cct = db.context.CourseCategories;

            var cats = from c in cs
                     join cc in cct on c.Id equals cc.CourseId
                     join ct in cts on cc.CategoryId equals ct.Id
                     select new Model.API.CourseCategory
                     {
                         Course = c.Name,
                         Category = ct.Name,
                         CategoryId = ct.Id,
                         CourseId =  c.Id
                     };

            var oList = cats.ToList();
            oList.Insert(0, new Model.API.CourseCategory() { Course="All", Category="All", CategoryId=-1, CourseId=-1});
            
            return oList;
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

        private static int GetCompletionPercent(int cId, int tId)
        {
            var topics = GetTopics(cId.ToString());
            var count = topics.Count();
            var index = topics.FindIndex(p => p.Id == tId) + 1;
            if (index == 1)
            {
                return 0;
            }
            else
            {
                var mod = (int)Math.Round((double)(100 * index + 1) / count); ;
                return mod;
            }

        }

        public static List<FullProgress> GetProgress(int u)
        {
            DBData db = DBData.Instance;
            var st = db.context.Students;
            var tp = db.context.Topics;
            var cs = db.context.Courses;


            var allProgress = db.context.Progresses.ToList();
            var progress = allProgress;

            if (u == 0)
            {
                progress = allProgress
              .Where(p => p.StudentId == GetUser()).ToList();
            }


            var ct = from p in progress
                     join s in st on p.StudentId equals s.Id
                     join t in tp on p.TopicId equals t.Id
                     join c in cs on t.CourseId equals c.Id
                     select new FullProgress
                     {
                         Name = $"{s.FirstName } {s.LastName}",
                         Course = c.Name,
                         Topic = t.Name,
                         Completion = $"{GetCompletionPercent(c.Id, t.Id)}%",
                         StudentId = s.Id,
                         CourseId = c.Id,
                         TopicId = t.Id
                     };

            return ct.ToList();
        }

        public static bool ProgressExist(int sId, int tId)
        {
            DBData db = DBData.Instance;
            var progresses = db.context.Progresses.ToList().SingleOrDefault(p => p.StudentId == sId && p.TopicId == tId);
            return (progresses != null);
        }

        public static string InsertProgress(string courseId)
        {
            DBData db = DBData.Instance;
            var sId = GetUser();//  UserId;
            var tId = GetTopics(courseId).First().Id;
            String message;

            if (!ProgressExist(sId, tId))
            {
                Progress pr = new Progress()
                {
                    StudentId = sId,
                    TopicId = tId,
                    Completion = 0
                };

                db.context.Progresses.Add(pr);
                db.context.SaveChanges();
                message = "New Course Enrolled";
            }
            else
            {
                message = "Cannot Enroll same course";
            }

            return message;
        }

        public static string UpdateProgress(int tId, int oldtId, int index)
        {
            DBData db = DBData.Instance;
            var sId = GetUser(); // UserId;
            String message;
            var result1 = db.context.Progresses;
            var result = result1.SingleOrDefault(b => b.StudentId == sId && b.TopicId == oldtId);


            if (result != null)
            {
                result.TopicId = tId;
                db.context.SaveChanges();
                message = $"Learning{result.TopicId}";
            }
            else
            {
                message = "Failed to start";
            }

            return message;
        }


        public static void SetUserId(int sUser)
        {
            DBData db = DBData.Instance;
            db.UserId = sUser;
        }

        public static int GetUser()
        {
            DBData db = DBData.Instance;
            return db.UserId;
        }

    }
}
