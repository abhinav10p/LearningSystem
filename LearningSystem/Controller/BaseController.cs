using LearningSystem.Model;
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
        public DBData db { get; }
        public BaseController()
        {
            db = DBData.Instance;
        }



        //Student
        public List<Student> GetStudents()//Student List
        {
            return db.context.Students.ToList();
        }

        public Model.DTO.StudentProfile GetStudentProfileById(string sId)//Student By Id
        {
            var dto = db.context.StudentProfiles
            .Select(p => new Model.DTO.StudentProfile
            {
                Email = p.Email,
                StudentId = p.StudentId,
                Contact = p.Contact,
                Name = $"{p.Student.FirstName} {p.Student.LastName}"
            })
            .SingleOrDefault(p => p.StudentId == int.Parse(sId));
            return dto;
        }

        public Model.DTO.StudentProfile GetStudentProfileByEmail(string sId, string pass)//Student By Email
        {
            var dto = db.context.StudentProfiles
           .Select(p => new Model.DTO.StudentProfile
           {
               Email = p.Email,
               StudentId = p.StudentId,
               Contact = p.Contact,
               Name = $"{p.Student.FirstName} {p.Student.LastName}",
               Password = (p.Password == pass)
           }).ToList()
           .SingleOrDefault(p => p.Email == sId);
            return dto;
        }

        public void InsertStudent(string p1, string p2, string p3, string p4, string p5)//Register Student
        {
            Student student = new Student()
            {
                FirstName = p1,
                LastName = p2,
                StudentProfile = new Model.DB.StudentProfile
                {
                    Contact = p3,
                    Email = p4,
                    Password = p5
                }
            };


            db.context.Students.Add(student);

            db.context.SaveChanges();
        }




        public List<Topic> GetTopics(string sId)//Topic List
        {
            return db.context.Topics
                .ToList()
                .Where(p => p.CourseId == int.Parse(sId)).ToList();
        }

        public List<Course> GetCourses()//Course List
        {
            return db.context.Courses
                .Include(c => c.Topics)
                .ToList();
        }

        public List<Model.DTO.CourseCategory> GetCategories()//Category List
        {

            var cs = db.context.Courses;
            var cts = db.context.Categories;
            var cct = db.context.CourseCategories;

            var cats = from c in cs
                       join cc in cct on c.Id equals cc.CourseId
                       join ct in cts on cc.CategoryId equals ct.Id
                       select new Model.DTO.CourseCategory
                       {
                           Course = c.Name,
                           Category = ct.Name,
                           CategoryId = ct.Id,
                           CourseId = c.Id
                       };

            var oList = cats.ToList();
            oList.Insert(0, new Model.DTO.CourseCategory() { Course = "All", Category = "All", CategoryId = -1, CourseId = -1 });

            return oList;
        }




        //Progress Methods
        private int GetCompletionPercent(int cId, int tId)
        {
            var topics = GetTopics(cId.ToString());
            var topicsCount = topics.Count();
            var index = topics.FindIndex(p => p.Id == tId) + 1;
            if (index == 1)
            {
                return 1;
            }
            else
            {
                var mod = (int)Math.Round((double)(100 * index + 1) / topicsCount); ;
                return mod;
            }

        }

        public List<Model.DTO.Progress> GetProgress(int u)
        {

            var st = db.context.Students;
            var tp = db.context.Topics;
            var cs = db.context.Courses;


            var progress = db.context.Progresses.ToList();

            if (u == 0)
            {
                progress = progress
              .Where(p => p.StudentId == GetUser()).ToList();
            }


            var ct = from p in progress
                     join s in st on p.StudentId equals s.Id
                     join t in tp on p.TopicId equals t.Id
                     join c in cs on t.CourseId equals c.Id
                     select new Model.DTO.Progress
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

        public bool ProgressExist(int sId, int tId)
        {

            var progresses = db.context.Progresses.ToList().SingleOrDefault(p => p.StudentId == sId && p.TopicId == tId);
            return (progresses != null);
        }

        public string InsertProgress(string courseId)
        {

            var sId = GetUser();//  UserId;
            var tId = GetTopics(courseId).First().Id;
            String message;

            if (!ProgressExist(sId, tId))
            {
                Model.DB.Progress pr = new Model.DB.Progress()
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

        public string UpdateProgress(int tId, int oldtId, int index)
        {

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




        public void SetUserId(int sUser)
        {
            db.UserId = sUser;
        }
        public int GetUser()
        {
            return db.UserId;
        }  
       
        public string GetUserInfo()
        {
            return db.UserInfo;
        }
        public void SetUserInfo(string sUser)
        {
            db.UserInfo = sUser;
        }



        public void NavTo(string windowName)
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

        private void IfwindowNoFound(string windowName)
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



        /// <summary>
        /// Mock Mehods
        /// </summary>
        public void CreateStudentMock()
        {

            db.CreateStudentMock();
        }
        public void CreateCategory()
        {
            db.CreateCategory();
        }
        public void CreateCourseMock()
        {
            db.CreateCourseMock();
        }

    }
}
