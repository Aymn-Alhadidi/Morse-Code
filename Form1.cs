﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_in_C__Windows_framework_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<string> SplitString(string Text, string delim)
        {
            List<string> vString = new List<string>();
            int Pos = 0;
            string sWord;

            while ((Pos = Text.IndexOf(delim)) != -1)
            {
                sWord = Text.Substring(0, Pos); // Store the word


                if (sWord != "")
                {
                    vString.Add(sWord);
                }

                Text = Text.Remove(0, Pos + delim.Length);
            }

            if (Text != delim)
                vString.Add(Text);

            return vString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEnglish.BackColor = System.Drawing.Color.FromArgb(249, 253, 213);
            txtMorse.BackColor = System.Drawing.Color.FromArgb  (249, 253, 213);

        }


        public static string LetterToMorse(char letter)
        {
            switch (Char.ToLower(letter))
            {
                case 'a':
                    return ".-";
                case 'b':
                    return "-...";
                case 'c':
                    return "-.-.";
                case 'd':
                    return "-..";
                case 'e':
                    return ".";
                case 'f':
                    return "..-.";
                case 'g':
                    return "--.";
                case 'h':
                    return "....";
                case 'i':
                    return "..";
                case 'j':
                    return ".---";
                case 'k':
                    return "-.-";
                case 'l':
                    return ".-..";
                case 'm':
                    return "--";
                case 'n':
                    return "-.";
                case 'o':
                    return "---";
                case 'p':
                    return ".--.";
                case 'q':
                    return "--.-";
                case 'r':
                    return ".-.";
                case 's':
                    return "...";
                case 't':
                    return "-";
                case 'u':
                    return "..-";
                case 'v':
                    return "...-";
                case 'w':
                    return ".--";
                case 'x':
                    return "-..-";
                case 'y':
                    return "-.--";
                case 'z':
                    return "--..";
                case '1':
                    return ".--.";
                case '2':
                    return "..-..";
                case '3':
                    return "...-.";
                case '4':
                    return "....-";
                case '5':
                    return "---";
                case '6':
                    return "......";
                case '7':
                    return "--..";
                case '8':
                    return "-....";
                case '9':
                    return "-..-";
                case '0':
                    return "____"; // Special case
                case ' ':
                    return " / "; // to separate between words
                default:
                    return "Wrong Letter";
            }
        }
        public static string WordToMorse(string OneWord)
        {
            string MorseWord = "";

            for(short i = 0; i<OneWord.Length; i++)
            {
                MorseWord += LetterToMorse(OneWord[i]) + " ";
            }
            return MorseWord;
        }

        static string ConvertToMorse(string Text)
        {
            string Mword = "";
            List<string> Words = SplitString(Text, " ");

            foreach (string item in Words)
            {
                Mword += WordToMorse(item) + "/ ";
            }

            return Mword;
        }
        private void txtEnglish_TextChanged(object sender, EventArgs e)
        {
            txtMorse.Text = ConvertToMorse(txtEnglish.Text);
        }

        private void txtMorse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
