using System;
using System.Windows.Forms;

namespace MorseCodeTranslator
{
   
    public class Program
    {

        /*  
        * This is a program that can translate alpha numeric text input to morsecode. 
        * It can also playback the morsecode to the user.
        * 
        * Copyright (C) 2017 Alex van der Waal - All Rights Reserved 
        * Last revised 201703101
        */

        /// <summary> 
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Morsecode());
        }
    }
}

