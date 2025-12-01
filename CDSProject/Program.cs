using CDSProject.View;
using System;
using System.Windows.Forms;

namespace CDSProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Halkan, StudentReg waa magaca foomkaaga ugu muhiimsan
            Application.Run(new StudentReg());
        }
    }
}