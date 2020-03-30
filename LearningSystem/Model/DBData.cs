using LearningSystem.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LearningSystem.Model
{
    public class DBData
    {
        private ELContext context { get; }

        private int userid;
        public int UserId { get { return userid; } set { userid = value; } }

        private DBData()
        {
            context = new ELContext();
        }


        private static DBData instance;

        public static DBData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBData();
                }

                return instance;
            }
        }

        #region


        public void CreateStudentMock()
        {

            Student student1 = new Student()
            {
                FirstName = "Malek",
                LastName = "Slimani",
                StudentProfile = new StudentProfile
                {
                    Contact = "8767868787",
                    Email = "malek@email.com",
                    Password = "1234"
                }
            };

            Student student2 = new Student()
            {
                FirstName = "Dhruba",
                LastName = "Rakshit",
                StudentProfile = new StudentProfile
                {
                    Contact = "7656757666",
                    Email = "dhruba@email.com",
                    Password = "1234"
                }
            };

            Student student3 = new Student()
            {
                FirstName = "Ana",
                LastName = "Velasquez",
                StudentProfile = new StudentProfile
                {
                    Contact = "87687687",
                    Email = "ana@email.com",
                    Password = "1234"
                }
            };
            try
            {
                context.Students.Add(student1);
                context.Students.Add(student2);
                context.Students.Add(student3);

                context.SaveChanges();

                MessageBox.Show("Student created");
            }
            catch
            {

            }

        }

        public void CreateCategory()
        {
            context.Categories.Add(new Category() { Name = "IT" });

            context.Categories.Add(new Category() { Name = "Project Management" });

            context.SaveChanges();

            MessageBox.Show("Categories Created");
        }

        public void CreateCourseMock()
        {

            using (ELContext context = new ELContext())
            {
                var kurs1 = new Course()
                {
                    Name = "C# .Net",
                    Description = "This is  basic foundation for C#",
                    Teacher = new Teacher()
                    {
                        TeacherProfile = new TeacherProfile()
                        {
                            FirstName = "Aidin",
                            LastName = "Mashinchi",
                            Contact = "76576876868",
                            Email = "aidin@email.com",
                            Password = "1234"
                        }
                    },
                    Lectures = 3,
                    TotalHours = 90,
                    CourseCategories = new List<CourseCategory>()
                    {
                           new CourseCategory
                          {
                            Category = new Category { Id=1}
                          }
                    },
                    Topics = new List<Topic>()
                    {
                           new Topic {Name="Topic Foundation 1"},
                           new Topic{Name="Important Before You Start"},
                           new Topic{Name="Programming Languages"},
                           new Topic{Name="Compilers vs Interpreters"},
                           new Topic{Name="History About C# Language"},
                           new Topic{Name="Object-oriented Programming"},
                           new Topic{Name="Overloaded Methods Exercise"},
                           new Topic{Name="Abstraction "},
                           new Topic{Name="Inheritance"},
                           new Topic{Name="Encapsulation"},
                           new Topic{Name="Non-generic Hashtable"},
                           new Topic{Name="Generic List <T>"},
                           new Topic{Name="NameValueCollection"},
                           new Topic{Name="Nested Tuples"}
                    }
                };
                var kurs2 = new Course()
                {
                    Name = "Project Management",
                    Description = "Project Management course",
                    Teacher = new Teacher()
                    {
                        TeacherProfile = new TeacherProfile()
                        {
                            FirstName = "Abhinav",
                            LastName = "Parankusham",
                            Contact = "4321421434234",
                            Email = "abhi@email.com",
                            Password = "1234"
                        }
                    },
                    Lectures = 2,
                    TotalHours = 40,
                    CourseCategories = new List<CourseCategory>()
                    {
                           new CourseCategory
                          {
                            Category = new Category { Id=2}
                          }
                    },
                    Topics = new List<Topic>()
                    {
                           new Topic{Name="Agile Foundation 1"},
                           new Topic{Name="Resource Management"},
                           new Topic{Name="Queries, Charts and Dashboards"},
                           new Topic{Name="Task boards and other features."},
                           new Topic{Name="Capacity Planning, Notifications"},
                           new Topic{Name="Create custom process"},
                           new Topic{Name="Review and PDF of Lecture"},
                           new Topic{Name="Scrum Management"},
                           new Topic{Name="work items"},
                           new Topic{Name="Integration with Excel"}
                    }
                };
                context.Attach(kurs1);
                context.Attach(kurs2);

                ShowEntityStatuses(context.ChangeTracker.Entries());

                context.Courses.Add(kurs1);
                context.Courses.Add(kurs2);

                context.SaveChanges();

                MessageBox.Show("Course and Teachers Created");

            }
        }

        private void ShowEntityStatuses(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: {entry.State.ToString()}");
            }
        }
        #endregion
    }
}
