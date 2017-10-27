using System;
using System.Windows.Forms;

namespace DirectoryStructureApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CreateDirectoryStructure());
            }
            catch(Exception ex)
            {
                throw ex;
            }           
        }
    }
}
