﻿using System;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormControls());
        }
    }
}
