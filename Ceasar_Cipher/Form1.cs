using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        private int key = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result1.Text = Caesar(textBox1.Text, key);
        }

        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                // Checks whether the character is a letter or not. 
                if (!char.IsLetter(letter))
                {
                    buffer[i] = letter;
                }
                else
                {
                    // Shift letters by positions determined by key
                    letter = (char)(letter + shift);

                    // Subtract 26 on overflow.
                    // Add 26 on underflow.
                    // Check whether the initial letter was upper or lower case
                    if (!char.IsUpper(buffer[i]))
                    {
                        if (letter > 'z')
                        {
                            letter = (char) (letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char) (letter + 26);
                        }
                    }
                    else if (char.IsUpper(buffer[i]))
                    {
                        if (letter > 'Z')
                        {
                            letter = (char) (letter - 26);
                        }
                        else if (letter < 'A')
                        {
                            letter = (char) (letter + 26);
                        }
                    }
                }

                // Store the array.
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
