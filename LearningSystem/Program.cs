using LearningSystem.Controller;
using System;
using System.Windows.Forms;

namespace LearningSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainBoard());

            /*if (BaseController.GetStudents().Count == 0)
            {
                Application.Run(new Mock());
            }
            else
            {
                Application.Run(new Login());
            }*/
           
        }
    }
}
