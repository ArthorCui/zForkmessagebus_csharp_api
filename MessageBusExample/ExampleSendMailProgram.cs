﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MessageBusExample
{
    static class ExampleSendMailProgram
    {
        /// <summary>
        /// The main entry point for the ExampleForm1 application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExampleForm1());
        }
    }
}
