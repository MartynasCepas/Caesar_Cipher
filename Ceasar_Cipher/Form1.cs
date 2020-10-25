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
        private int key;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyUp += new KeyEventHandler(TextBox1_KeyPress);
            textBox2.KeyUp += new KeyEventHandler(TextBox2_KeyPress);
        }

        private void TextBox1_KeyPress(object sender, EventArgs e)
        {
            ChangeEncryptionResult();
        }

        private void ChangeEncryptionResult()
        {
            result1.Text = Caesar(textBox1.Text, key);
        }

        private void TextBox2_KeyPress(object sender, EventArgs e)
        {
            ChangeDecryptionResult();
        }

        private void ChangeDecryptionResult()
        {
            result2.Text = Caesar(textBox2.Text, key * -1);
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            key = trackBar1.Value;
            label4.Text = "Key: " + key;
            ChangeEncryptionResult();
            ChangeDecryptionResult();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
