using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safefunction
{
    public class Program
    {
        public static List<User> Users = new List<User>();
        public static string loggeduser;
        public static Matches matches = new Matches();

        // User baby = new User();
        //public static List<string> users = new List<string>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new installForm());
        }
    }
}
