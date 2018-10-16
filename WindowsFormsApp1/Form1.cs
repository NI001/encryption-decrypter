using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string a;  // read strings from the UI
        char[] entry, encrypted, decrypted, temp;
        // encryption variables

        public Form1()
        {
            InitializeComponent();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encryption_TextChanged(object sender, EventArgs e)
        {

        }

        private void encrypt2_Click(object sender, EventArgs e)
        {
            // reads user input and converts to a character array
            a = this.input.Text;
            entry = a.ToCharArray();
            //set the sizes of other encryption variables
            encrypted = new char[a.Length];
            decrypted = new char[a.Length];
            // substitution encryption
            for (int i = 0; i < a.Length; i++)
                switch (entry[i])
                {
                    case 'a':
                        encrypted[i] = '1'; break;
                    case 'b':
                        encrypted[i] = '3'; break;
                    case 'c':
                        encrypted[i] = '5'; break;
                    case 'd':
                        encrypted[i] = '7'; break;
                    case 'e':
                        encrypted[i] = '9'; break;
                    case 'f':
                        encrypted[i] = '2'; break;
                    case 'g':
                        encrypted[i] = '4'; break;
                    case 'h':
                        encrypted[i] = '6'; break;
                    case 'i':
                        encrypted[i] = '8'; break;
                    case 'j':
                        encrypted[i] = '0'; break;
                    case 'k':
                        encrypted[i] = 'a'; break;
                    case 'l':
                        encrypted[i] = 'b'; break;
                    case 'm':
                        encrypted[i] = 'c'; break;
                    case 'n':
                        encrypted[i] = 'd'; break;
                    case 'o':
                        encrypted[i] = 'e'; break;
                    case 'p':
                        encrypted[i] = 'f'; break;
                    case 'q':
                        encrypted[i] = 'g'; break;
                    case 'r':
                        encrypted[i] = 'h'; break;
                    case 's':
                        encrypted[i] = 'i'; break;
                    case 't':
                        encrypted[i] = 'j'; break;
                    case 'u':
                        encrypted[i] = 'k'; break;
                    case 'v':
                        encrypted[i] = 'l'; break;
                    case 'w':
                        encrypted[i] = 'm'; break;
                    case 'x':
                        encrypted[i] = 'n'; break;
                    case 'y':
                        encrypted[i] = 'o'; break;
                    case 'z':
                        encrypted[i] = 'p'; break;
                    case '1':
                        encrypted[i] = 'q'; break;
                    case '2':
                        encrypted[i] = 'r'; break;
                    case '3':
                        encrypted[i] = 's'; break;
                    case '4':
                        encrypted[i] = 't'; break;
                    case '5':
                        encrypted[i] = 'u'; break;
                    case '6':
                        encrypted[i] = 'v'; break;
                    case '7':
                        encrypted[i] = 'w'; break;
                    case '8':
                        encrypted[i] = 'x'; break;
                    case '9':
                        encrypted[i] = 'y'; break;
                    case '0':
                        encrypted[i] = 'z'; break;
                    case ' ':
                        encrypted[i] = '/'; break;
                    case '.':
                        encrypted[i] = '<'; break;
                }
            this.encryption.Text = new string(encrypted);
        }

        private void decrypt1_Click(object sender, EventArgs e)
        {
            // reads user input and converts to a character array
            //a = this.input.Text;
            //entry = a.ToCharArray();
            //set the sizes of other encryption variables

            // reversal decrypition
            for (int i = 0; i < a.Length; i++)
            {
                decrypted[i] = encrypted[entry.Length - 1 - i];

            }
            this.decryption.Text = new string(decrypted);
        }

        private void decrypt2_Click(object sender, EventArgs e)
        {
            // reads user input and converts to a character array
            a = this.input.Text;
            entry = a.ToCharArray();
            //set the sizes of other encryption variables
           // encrypted = new char[a.Length];
           // decrypted = new char[a.Length];
            // substitution decryption
            for (int i = 0; i < a.Length; i++)
                switch (encrypted[i])
                {
                    case 'a':
                        decrypted[i] = 'k'; break;
                    case 'b':
                        decrypted[i] = 'l'; break;
                    case 'c':
                        decrypted[i] = 'm'; break;
                    case 'd':
                        decrypted[i] = 'n'; break;
                    case 'e':
                        decrypted[i] = 'o'; break;
                    case 'f':
                        decrypted[i] = 'p'; break;
                    case 'g':
                        decrypted[i] = 'q'; break;
                    case 'h':
                        decrypted[i] = 'r'; break;
                    case 'i':
                        decrypted[i] = 's'; break;
                    case 'j':
                        decrypted[i] = 't'; break;
                    case 'k':
                        decrypted[i] = 'u'; break;
                    case 'l':
                        decrypted[i] = 'v'; break;
                    case 'm':
                        decrypted[i] = 'w'; break;
                    case 'n':
                        decrypted[i] = 'x'; break;
                    case 'o':
                        decrypted[i] = 'y'; break;
                    case 'p':
                        decrypted[i] = 'z'; break;
                    case 'q':
                        decrypted[i] = '1'; break;
                    case 'r':
                        decrypted[i] = '2'; break;
                    case 's':
                        decrypted[i] = '3'; break;
                    case 't':
                        decrypted[i] = '4'; break;
                    case 'u':
                        decrypted[i] = '5'; break;
                    case 'v':
                        decrypted[i] = '6'; break;
                    case 'w':
                        decrypted[i] = '7'; break;
                    case 'x':
                        decrypted[i] = '8'; break;
                    case 'y':
                        decrypted[i] = '9'; break;
                    case 'z':
                        decrypted[i] = '0'; break;
                    case '1':
                        decrypted[i] = 'a'; break;
                    case '2':
                        decrypted[i] = 'f'; break;
                    case '3':
                        decrypted[i] = 'b'; break;
                    case '4':
                        decrypted[i] = 'g'; break;
                    case '5':
                        decrypted[i] = 'c'; break;
                    case '6':
                        decrypted[i] = 'h'; break;
                    case '7':
                        decrypted[i] = 'd'; break;
                    case '8':
                        decrypted[i] = 'i'; break;
                    case '9':
                        decrypted[i] = 'e'; break;
                    case '0':
                        decrypted[i] = 'j'; break;
                    case '/':
                        decrypted[i] = ' '; break;
                    case '<':
                        decrypted[i] = '.'; break;
                }
            this.decryption.Text = new string(decrypted);
        }

        private void decrypt3_Click(object sender, EventArgs e)
        {
            // reads user input and converts to a character array
            a = this.input.Text;
            entry = a.ToCharArray();
            //set the sizes of other encryption variables
            //encrypted = new char[a.Length];
            //decrypted = new char[a.Length];
            //temp = new char[a.Length];
            // mixed decryption
            for (int i = 0; i < entry.Length; i++)
            {
                temp[i] = encrypted[entry.Length - 1 - i];

            }

            for (int i = 0; i < a.Length; i++)
                switch (temp[i])
                {
                    case 'a':
                        temp[i] = 'k'; break;
                    case 'b':
                        temp[i] = 'l'; break;
                    case 'c':
                        temp[i] = 'm'; break;
                    case 'd':
                        temp[i] = 'n'; break;
                    case 'e':
                        temp[i] = 'o'; break;
                    case 'f':
                        temp[i] = 'p'; break;
                    case 'g':
                        temp[i] = 'q'; break;
                    case 'h':
                        temp[i] = 'r'; break;
                    case 'i':
                        temp[i] = 's'; break;
                    case 'j':
                        temp[i] = 't'; break;
                    case 'k':
                        temp[i] = 'u'; break;
                    case 'l':
                        temp[i] = 'v'; break;
                    case 'm':
                        temp[i] = 'w'; break;
                    case 'n':
                        temp[i] = 'x'; break;
                    case 'o':
                        temp[i] = 'y'; break;
                    case 'p':
                        temp[i] = 'z'; break;
                    case 'q':
                        temp[i] = '1'; break;
                    case 'r':
                        temp[i] = '2'; break;
                    case 's':
                        temp[i] = '3'; break;
                    case 't':
                        temp[i] = '4'; break;
                    case 'u':
                        temp[i] = '5'; break;
                    case 'v':
                        temp[i] = '6'; break;
                    case 'w':
                        temp[i] = '7'; break;
                    case 'x':
                        temp[i] = '8'; break;
                    case 'y':
                        temp[i] = '9'; break;
                    case 'z':
                        temp[i] = '0'; break;
                    case '1':
                        temp[i] = 'a'; break;
                    case '2':
                        temp[i] = 'f'; break;
                    case '3':
                        temp[i] = 'b'; break;
                    case '4':
                        temp[i] = 'g'; break;
                    case '5':
                        temp[i] = 'c'; break;
                    case '6':
                        temp[i] = 'h'; break;
                    case '7':
                        temp[i] = 'd'; break;
                    case '8':
                        temp[i] = 'i'; break;
                    case '9':
                        temp[i] = 'e'; break;
                    case '0':
                        temp[i] = 'j'; break;
                    case '/':
                        temp[i] = ' '; break;
                    case '<':
                        temp[i] = '.'; break;
                }
            this.decryption.Text = new string(temp);
        }

        private void encrypt3_Click(object sender, EventArgs e)
        {
            // reads user input and converts to a character array
            a = this.input.Text;
            entry = a.ToCharArray();
            //set the sizes of other encryption variables
            encrypted = new char[a.Length];
            decrypted = new char[a.Length];
            temp = new char[a.Length];
            // mixed encryption
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = entry[entry.Length - 1 - i];

            }

            for (int i = 0; i < a.Length; i++)
                switch (temp[i])
                {
                    case 'a':
                        temp[i] = '1'; break;
                    case 'b':
                        temp[i] = '3'; break;
                    case 'c':
                        temp[i] = '5'; break;
                    case 'd':
                        temp[i] = '7'; break;
                    case 'e':
                        temp[i] = '9'; break;
                    case 'f':
                        temp[i] = '2'; break;
                    case 'g':
                        temp[i] = '4'; break;
                    case 'h':
                        temp[i] = '6'; break;
                    case 'i':
                        temp[i] = '8'; break;
                    case 'j':
                        temp[i] = '0'; break;
                    case 'k':
                        temp[i] = 'a'; break;
                    case 'l':
                        temp[i] = 'b'; break;
                    case 'm':
                        temp[i] = 'c'; break;
                    case 'n':
                        temp[i] = 'd'; break;
                    case 'o':
                        temp[i] = 'e'; break;
                    case 'p':
                        temp[i] = 'f'; break;
                    case 'q':
                        temp[i] = 'g'; break;
                    case 'r':
                        temp[i] = 'h'; break;
                    case 's':
                        temp[i] = 'i'; break;
                    case 't':
                        temp[i] = 'j'; break;
                    case 'u':
                        temp[i] = 'k'; break;
                    case 'v':
                        temp[i] = 'l'; break;
                    case 'w':
                        temp[i] = 'm'; break;
                    case 'x':
                        temp[i] = 'n'; break;
                    case 'y':
                        temp[i] = 'o'; break;
                    case 'z':
                        temp[i] = 'p'; break;
                    case '1':
                        temp[i] = 'q'; break;
                    case '2':
                        temp[i] = 'r'; break;
                    case '3':
                        temp[i] = 's'; break;
                    case '4':
                        temp[i] = 't'; break;
                    case '5':
                        temp[i] = 'u'; break;
                    case '6':
                        temp[i] = 'v'; break;
                    case '7':
                        temp[i] = 'w'; break;
                    case '8':
                        temp[i] = 'x'; break;
                    case '9':
                        temp[i] = 'y'; break;
                    case '0':
                        temp[i] = 'z'; break;
                    case ' ':
                        temp[i] = '/'; break;
                    case '.':
                        temp[i] = '<'; break;
                }
            for (int i = 0; i < temp.Length; i++)
            { encrypted[i] = temp[i]; }

            this.encryption.Text = new string(temp);
        }

        private void encrypt1_Click(object sender, EventArgs e)
        {
            // reads user input and converts to a character array
            a = this.input.Text;
            entry = a.ToCharArray();
            //set the sizes of other encryption variables
            encrypted = new char[a.Length];
            decrypted = new char[a.Length];
            // reversal encryption
            for (int i = 0; i < a.Length; i++)
            {
                encrypted[i] = entry[entry.Length-1-i];

            }
            this.encryption.Text = new string(encrypted);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
