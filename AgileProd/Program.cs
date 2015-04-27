using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AgileProd
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
            //CreateCSVFilesV2 csvF = new CreateCSVFilesV2(@"Z:\Studies\Software Maintenance\Database\people.txt", 
            //                                             @"Z:\Studies\Software Maintenance\Database\members.txt", 
            //                                             @"Z:\Studies\Software Maintenance\Database\committee.txt", 
            //                                             @"Z:\Studies\Software Maintenance\Database\bankAccounts.txt", 
            //                                             @"Z:\Studies\Software Maintenance\Database\messageInbox.txt");
            //csvF.writeFiles();
            Application.Run(new LoginForm());
        }
    }
}
