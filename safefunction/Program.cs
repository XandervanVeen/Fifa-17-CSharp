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
        public static Matches matches = new Matches();
        public static string path = @"bets\users.json";
        public static string pathusers = @"bets\users.json";
        public static string key;

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
