using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApp
{
    public partial class MainForm : Form
    {
        private string enteredPass = "";
        private string newPass = "";
        
        public MainForm()
        {
            InitializeComponent();
            passwordTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            enteredPass = passwordTextBox.Text;
            mutatePassword();
            newPassForm res = new newPassForm(newPass);
            res.ShowDialog();
        }

        private void mutatePassword() {
            int numVowels = 0;
            newPass = enteredPass;
            for (int i = 0; i < enteredPass.Length; i++)
            {
                // replace vowels
                if (charIsVowel(enteredPass[i]))
                {
                    numVowels++;
                    if (numVowels == 1)
                    {
                        replaceChar(i, '1');
                    }
                    if (numVowels == 2)
                    {
                        replaceChar(i, '2');
                    }
                    if (numVowels > 2)
                    {
                        replaceChar(i, '9');
                    }
                }
                // replace digits 0-9
                if (char.IsDigit(enteredPass[i]))
                {
                    replaceChar(i, 'Z');
                }
            }
            reverse();
        }

        private void replaceChar(int i, char c) {
            newPass = newPass.Remove(i, 1);
            newPass = newPass.Insert(i, char.ToString(c));
       }

        private void reverse() {
            string result = "";
            for (int i = newPass.Length - 1; i > -1; i--) {
                result += newPass[i];
            }
            newPass = result;
        }

        private bool charIsVowel(char c) {
            c = char.ToLower(c);
            switch (c) {
                case 'a': return true;
                case 'e': return true;
                case 'i': return true;
                case 'o': return true;
                case 'u': return true;
           }
            return false;
       }
    }
}
