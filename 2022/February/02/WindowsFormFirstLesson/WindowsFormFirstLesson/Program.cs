using System;
using System.Windows.Forms;

namespace WindowsFormFirstLesson
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SendMessage());
        }
    }
}
