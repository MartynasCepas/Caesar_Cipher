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

        // These actions are performed before form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            encryptTextBox.KeyUp += new KeyEventHandler(TextBox1_KeyPress);
            decryptTextBox.KeyUp += new KeyEventHandler(TextBox2_KeyPress);
        }

        // Encryption result gets recalculated every time a key is pressed in related textbox
        private void TextBox1_KeyPress(object sender, EventArgs e)
        {
            ChangeEncryptionResult();
        }

        private void ChangeEncryptionResult()
        {
            ecryptedTextBox.Text = Caesar(encryptTextBox.Text, key);
        }

        // Decryption result gets recalculated every time a key is pressed in related textbox
        private void TextBox2_KeyPress(object sender, EventArgs e)
        {
            ChangeDecryptionResult();
        }

        private void ChangeDecryptionResult()
        {
            decryptedTextBox.Text = Caesar(decryptTextBox.Text, key * -1);
        }


        /// <summary>
        /// Algorithm which calculates caesar cipher according to given parameters
        /// </summary>
        /// <param name="value"> Text to be encrypted/decrypted </param>
        /// <param name="shift"> Cipher key. Shifts every letter by given number of positions </param>
        /// <returns> Encoded/Decoded message </returns>
        public string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                // Checks whether the character is a letter or not. Does not change it if it's not a letter.
                if (!char.IsLetter(letter))
                {
                    buffer[i] = letter;
                }
                else
                {
                    // Shift letters by positions determined by key
                    letter = (char)(letter + shift);

                    // Check whether the initial letter was upper or lower case
                    // Subtract 26 on overflow.
                    // Add 26 on underflow.
                    if (!char.IsUpper(buffer[i]))
                    {
                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                    }
                    else if (char.IsUpper(buffer[i]))
                    {
                        if (letter > 'Z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'A')
                        {
                            letter = (char)(letter + 26);
                        }
                    }
                }

                // Store the array.
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        // Encryption and decryption fields gets updated every time cipher key is changed
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            key = keyTrackBar.Value;
            keyLabel.Text = "Key: " + key;
            ChangeEncryptionResult();
            ChangeDecryptionResult();
        }
    }
}
