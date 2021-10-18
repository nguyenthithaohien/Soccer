using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Management_Premier_League
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserTextbox.Text == "admin" && PassTextbox.Text == "123")
            {
                HomePage hp = new HomePage();
                this.Hide();
                hp.Show();
            }
        }
    }
}
