﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Karamelle
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        public static int IDUsuario = -1;
        public static string Usuario = "";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
