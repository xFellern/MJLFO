﻿using System;
using System.Windows.Forms;
namespace MJLFO_v2_0
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MJLFO_v2_0());
        }
    }
}