﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemeMaker.ObserverLayer;
using MemeMaker.Meme;
using MemeMaker.Domain;

namespace MemeMaker {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main () {
            MemeService memeService = new MemeService ();

            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new MemeMakerView (memeService));
        }
    }
}
