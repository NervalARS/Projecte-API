﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using M15_ProjecteConsumidor.Controlador;

namespace M15_ProjecteConsumidor
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InicioController IC = new InicioController();
        }
    }
}
