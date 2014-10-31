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
    public partial class newPassForm : Form
    {
        public newPassForm(string password)
        {
            InitializeComponent();
            newPassResult.Text = password;
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
