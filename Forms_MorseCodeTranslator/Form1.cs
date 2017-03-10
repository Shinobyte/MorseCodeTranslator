using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace MorseCodeTranslator
{
    public partial class Morsecode : Form
    {
        
        public Morsecode()
        {
            InitializeComponent();

            // The backgroundworker object on which the time consuming operation shall be executed.
            // Needs to be in this scope with initializeComponent!
            // NOTE: didnt work soooo long due to leading with BackgroundWorker! 
            //(ie. BackgroundWorker gw_playMorseCode = new BackgroundWorker();
            bgw_playMorseCode = new BackgroundWorker();
            
            // Create a background worker thread that ReportsProgress &
            // SupportsCancellation. Hook up the appropriate events.
            bgw_playMorseCode.DoWork += Bgw_playMorseCode_DoWork1;
            bgw_playMorseCode.ProgressChanged += Bgw_playMorseCode_ProgressChanged1;
            bgw_playMorseCode.RunWorkerCompleted += Bgw_playMorseCode_RunWorkerCompleted1;
            bgw_playMorseCode.WorkerReportsProgress = true;
            bgw_playMorseCode.WorkerSupportsCancellation = true;

            //Fill morseCodeDictionary with all morsecode<char, string>.
            morseCodeDictionary.Add('A', ".-");
            morseCodeDictionary.Add('B', "-...");
            morseCodeDictionary.Add('C', "-.-.");
            morseCodeDictionary.Add('D', "-..");
            morseCodeDictionary.Add('E', ".");
            morseCodeDictionary.Add('F', "..-.");
            morseCodeDictionary.Add('G', "--.");
            morseCodeDictionary.Add('H', "....");
            morseCodeDictionary.Add('I', "..");
            morseCodeDictionary.Add('J', ".---");
            morseCodeDictionary.Add('K', "-.-");
            morseCodeDictionary.Add('L', ".-..");
            morseCodeDictionary.Add('M', "--");
            morseCodeDictionary.Add('N', "-.");
            morseCodeDictionary.Add('O', "---");
            morseCodeDictionary.Add('P', ".--.");
            morseCodeDictionary.Add('Q', "--.-");
            morseCodeDictionary.Add('R', ".-.");
            morseCodeDictionary.Add('S', "...");
            morseCodeDictionary.Add('T', "-");
            morseCodeDictionary.Add('U', "..-");
            morseCodeDictionary.Add('V', "...-");
            morseCodeDictionary.Add('W', ".--");
            morseCodeDictionary.Add('X', "-..-");
            morseCodeDictionary.Add('Y', "-.--");
            morseCodeDictionary.Add('Z', "--..");
            morseCodeDictionary.Add('0', "-----");
            morseCodeDictionary.Add('1', ".----");
            morseCodeDictionary.Add('2', "..---");
            morseCodeDictionary.Add('3', "...--");
            morseCodeDictionary.Add('4', "....-");
            morseCodeDictionary.Add('5', ".....");
            morseCodeDictionary.Add('6', "-....");
            morseCodeDictionary.Add('7', "--...");
            morseCodeDictionary.Add('8', "---..");
            morseCodeDictionary.Add('9', "----.");

            // Disable the Stop button on form, it gets enabled when the user hits play
            btnCancel.Enabled = false;
        }


        // On completed background worker do the appropriate task
        void Bgw_playMorseCode_RunWorkerCompleted1(object sender, RunWorkerCompletedEventArgs e)
        {
            // The background process is complete. We need to inspect
            // our response to see if an error occurred, a cancel was
            // requested or if we completed successfully. 
            if (e.Cancelled)
            {
                lblStatus.Text = "Playback cancelled.";
            }
 
            // Check to see if an error occurred in the background process.
            else if (e.Error != null)
            {
                lblStatus.Text = "Error during playback operation.";
            }
            else
            {
                // Everything completed normally.
                lblStatus.Text = "Playback complete.";
            }

            //Change the status of the buttons on the UI accordingly
            btnStartAsyncOperation.Enabled = true;
            btnCancel.Enabled = false;
        }
        

        // The progress bar is updated here on every called bgw_playMorseCode.ReportProgress(percentage); 
        void Bgw_playMorseCode_ProgressChanged1(object sender, ProgressChangedEventArgs e)
        {
            // Update the progressBar with the integer supplied to us from the
            // ReportProgress() function. (line 133)  
            pbr_PlayProgression.Value = e.ProgressPercentage;
            lblStatus.Text = "Playing Morsecode ... " + pbr_PlayProgression.Value.ToString() + "%";
        }


        // Start of actual work on seperate thread. Time consuming operations go here!
        public void Bgw_playMorseCode_DoWork1(object sender, DoWorkEventArgs e)
        {
            // The sender is the BackgroundWorker object we need it to
            // report progress and check for cancellation.
            // NOTE : Never play with the UI thread here...
            
            // Get the user input from textbox.
            string input = tbx_EnterText.Text;

            // In case user enters lowercase, convert to uppercase so it matches dictionary.
            input = input.ToUpper();

            // Declare counter outside of the foreach loop below.
            int counter = 0;

            //Play wav for each character in input
            foreach (char character in input)
            {
                // Do the math to update the progressbar with the right percentage.
                // Looks at user input and increments every loop. 
                counter += 1;
                int percentage = (counter * 100) / input.Length;
                bgw_playMorseCode.ReportProgress(percentage);

                // Check if user initiated a cancel during playback, if so set the e.Cancel flag
                // so that the WorkerCompleted event knows that the process was cancelled.
                if (bgw_playMorseCode.CancellationPending)
                    {
                        e.Cancel = true;
                        bgw_playMorseCode.ReportProgress(0);
                        return;
                    }
                    if (morseCodeDictionary.ContainsKey(character))
                    {
                    if (character == 'A')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_A);
                        audio.PlaySync();
                        
                    }
                    if (character == 'B')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_B);
                        audio.PlaySync();
                    }
                    if (character == 'C')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_C);
                        audio.PlaySync();
                    }
                    if (character == 'D')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_D);
                        audio.PlaySync();
                    }
                    if (character == 'E')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_E);
                        audio.PlaySync();
                    }
                    if (character == 'F')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_F);
                        audio.PlaySync();
                    }
                    if (character == 'G')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_G);
                        audio.PlaySync();
                    }
                    if (character == 'H')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_H);
                        audio.PlaySync();
                    }
                    if (character == 'I')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_I);
                        audio.PlaySync();
                    }
                    if (character == 'J')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_J);
                        audio.PlaySync();
                    }
                    if (character == 'K')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_K);
                        audio.PlaySync();
                    }
                    if (character == 'L')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_L);
                        audio.PlaySync();
                    }
                    if (character == 'M')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_M);
                        audio.PlaySync();
                    }
                    if (character == 'N')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_N);
                        audio.PlaySync();
                    }
                    if (character == 'O')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_O);
                        audio.PlaySync();
                    }
                    if (character == 'P')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_P);
                        audio.PlaySync();
                    }
                    if (character == 'Q')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_Q);
                        audio.PlaySync();
                    }
                    if (character == 'R')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_R);
                        audio.PlaySync();
                    }
                    if (character == 'S')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_S);
                        audio.PlaySync();
                    }
                    if (character == 'T')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_T);
                        audio.PlaySync();
                    }
                    if (character == 'U')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_U);
                        audio.PlaySync();
                    }
                    if (character == 'V')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_V);
                        audio.PlaySync();
                    }
                    if (character == 'W')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_W);
                        audio.PlaySync();
                    }
                    if (character == 'X')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_X);
                        audio.PlaySync();
                    }
                    if (character == 'Y')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_Y);
                        audio.PlaySync();
                    }
                    if (character == 'Z')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_Z);
                        audio.PlaySync();
                    }
                    if (character == '0')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_0);
                        audio.PlaySync();
                    }
                    if (character == '1')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_1);
                        audio.PlaySync();
                    }
                    if (character == '2')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_2);
                        audio.PlaySync();
                    }
                    if (character == '3')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_3);
                        audio.PlaySync();
                    }
                    if (character == '4')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_4);
                        audio.PlaySync();
                    }
                    if (character == '5')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_5);
                        audio.PlaySync();
                    }
                    if (character == '6')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_6);
                        audio.PlaySync();
                    }
                    if (character == '7')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_7);
                        audio.PlaySync();
                    }
                    if (character == '8')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_8);
                        audio.PlaySync();
                    }
                    if (character == '9')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morsecode_9);
                        audio.PlaySync();
                    }
                }
            }
            //Report 100% completion on operation completed
            bgw_playMorseCode.ReportProgress(100);
        }


        // Create dictionary containing all morsecode characters char to string 
        public static Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>();


        // Create a method. Translate alphanumeric to morsecode. 
        public static string morseCode_Translator(string input) // Method 
        {
            // Remove space character from dictionary now so we can get / dividers, else if below.
            morseCodeDictionary.Remove(' ');

            StringBuilder stringBuilder = new StringBuilder();
            foreach (char character in input)
            {
                if (morseCodeDictionary.ContainsKey(character))
                {
                    stringBuilder.Append(morseCodeDictionary[character] + " ");
                }
                else if (character == ' ')
                {
                    stringBuilder.Append("/ ");
                }
                else
                {
                    stringBuilder.Append(character + " ");
                }
            }
            return stringBuilder.ToString();
        }


        ///
        ///Form Inputs below this point.
        ///

        private void button1_Click(object sender, EventArgs e)
        {
            // Get input from textbox1 
            string input = tbx_EnterText.Text;
            // In case user enters lowercase, convert to uppercase so it matches dictionary.
            input = input.ToUpper(); 
            // Put the input trough the morseCode_Translator method
            string output = morseCode_Translator(input);
            tbx_Morsecode.Text = output;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Copy the content of textBox2 to the clipboard
            Clipboard.SetText(tbx_Morsecode.Text);
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // (About) Show an About messagebox to user 
            MessageBox.Show("Program:\t\tText to Morse Code Translator\nAuthor:\t\tAlex van der Waal\n.NETFramework:\tv4.5.2\n\nCopyright:\t© 2017 Shinobyte\n\t\t"+
                "All rights reserved.\n\nWebsite:\t\tShinobyte.github.io");
        }
        

        private void size10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // (Options) Set font size and style of different menu items
            lbl_ApplicationName.Font = new Font("Verdana", 10);
            lbl_AuthorName.Font = new Font("Verdana", 10);
            lblStatus.Font = new Font("Verdana", 10);
            tbx_EnterText.Font = new Font("Verdana", 10);
            tbx_Morsecode.Font = new Font("Verdana", 10);
            btn_SubmitText.Font = new Font("Verdana", 10);
            btn_Clipboard.Font = new Font("Verdana", 10);
            btnStartAsyncOperation.Font = new Font("Verdana", 10);
            btnCancel.Font = new Font("Verdana", 10);
        }


        private void size12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // (Options) Set font size and style of different menu items
            lbl_ApplicationName.Font = new Font("Verdana", 12);
            lbl_AuthorName.Font = new Font("Verdana", 12);
            lblStatus.Font = new Font("Verdana", 12);
            tbx_EnterText.Font = new Font("Verdana", 12);
            tbx_Morsecode.Font = new Font("Verdana", 12);
            btn_SubmitText.Font = new Font("Verdana", 12);
            btn_Clipboard.Font = new Font("Verdana", 12);
            btnStartAsyncOperation.Font = new Font("Verdana", 12);
            btnCancel.Font = new Font("Verdana", 12);
        }


        private void size14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // (Options) Set font size and style of different menu items
            lbl_ApplicationName.Font = new Font("Verdana", 14);
            lbl_AuthorName.Font = new Font("Verdana", 14);
            lblStatus.Font = new Font("Verdana", 14);
            tbx_EnterText.Font = new Font("Verdana", 14);
            tbx_Morsecode.Font = new Font("Verdana", 14);
            btn_SubmitText.Font = new Font("Verdana", 14);
            btn_Clipboard.Font = new Font("Verdana", 14);
            btnStartAsyncOperation.Font = new Font("Verdana", 14);
            btnCancel.Font = new Font("Verdana", 14);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get input from textbox1 
            string input = tbx_EnterText.Text;

            // In case user enters lowercase, convert to uppercase so it matches dictionary. 
            input = input.ToUpper();

            // Add temporary space to dictionary if the input contains a space and its not already in the dictionary
            // This allows the user to input a space without triggering the " not alphanumeric" error.
            char[] inputToCharArray = input.ToCharArray();
            foreach (char character in inputToCharArray)
            {
                if (character == ' ' && morseCodeDictionary.ContainsKey(' ') == false)
                {
                    morseCodeDictionary.Add(' ', "");
                }
            }

            // Check realtime if character input is listed in dictionary, if not trow an suggestion messagebox
            foreach (char character in input)
                if (morseCodeDictionary.ContainsKey(character) == false)
                {
                    MessageBox.Show("The character  " + character + "  is not an alphanumeric character." +
                        "\nAlphanumeric characters consist of:\n\nThe alphabet [A to Z] and the numbers" +
                        "[0 to 9].\n\nPlease try again.");
                }
        }


        private void btnStartAsyncOperation_Click_2(object sender, EventArgs e)
        {
            //Change the status of the buttons on the UI accordingly
            //The start button is disabled as soon as the background operation is started
            //The Cancel button is enabled so that the user can stop the operation 
            //at any point of time during the execution
            btnStartAsyncOperation.Enabled = false;
            btnCancel.Enabled = true;

            // Kickoff the worker thread to begin it's DoWork function.
            bgw_playMorseCode.RunWorkerAsync();
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (bgw_playMorseCode.IsBusy)
            {

                // Notify the worker thread that a cancel has been requested.
                // The cancel will not actually happen until the thread in the
                // DoWork checks the bgw_playMorseCode.CancellationPending flag. 

                bgw_playMorseCode.CancelAsync();

            }
        }
    }
}
