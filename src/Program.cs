// <copyright file="Program.cs" company="OnlyTXT Developers">
// Copyright (c) 2025 Neil McNeight.
// Read the LICENSE file in the root project directory for more details.
// </copyright>

using System;
using System.Windows.Forms;

namespace OnlyTXT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
#if NET6_0_OR_GREATER
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
#else
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#endif
            Application.Run(new OnlyForm());
        }
    }
}
