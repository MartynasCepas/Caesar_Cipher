using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Caesar_EncodeLettersOnly()
        {
            string messageToEncode = "Labas";
            int key = 5;
            var form = new Form1();

            Assert.AreEqual("Qfgfx", form.Caesar(messageToEncode, key));
        }

        [TestMethod()]
        public void Caesar_EncodeTextWithSymbols()
        {
            string messageToEncode = "Hello world! 12345 @ # $";
            int key = 8;
            var form = new Form1();

            Assert.AreEqual("Pmttw ewztl! 12345 @ # $", form.Caesar(messageToEncode, key));
        }

        [TestMethod()]
        public void Caesar_EncodeEmpty()
        {
            string messageToEncode = "";
            int key = 10;
            var form = new Form1();

            Assert.AreEqual("", form.Caesar(messageToEncode, key));
        }

        [TestMethod()]
        public void Caesar_DecodeLettersOnly()
        {
            string messageToEncode = "Qfgfx";
            int key = -5;
            var form = new Form1();

            Assert.AreEqual("Labas", form.Caesar(messageToEncode, key));
        }

        [TestMethod()]
        public void Caesar_DecodeTextWithSymbols()
        {
            string messageToEncode = "Pmttw ewztl! 12345 @ # $";
            int key = -8;
            var form = new Form1();

            Assert.AreEqual("Hello world! 12345 @ # $", form.Caesar(messageToEncode, key));
        }
    }
}