using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace VanartInventoryWF
{
    public partial class loginForm : Form
    {
        FBConnection fb;

        public loginForm()
        {
            fb = new FBConnection();

            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await fb.client.GetAsync("users/" + usernameTextBox.Text);
            User user = response.ResultAs<User>();

            if(user != null)
            {
                //MessageBox.Show(user.name);
                if(user.password == passwordTextBox.Text)
                {

                    if(user.password == "VANART")
                    {
                        MessageBox.Show("You must change your password!");
                        ChangePassword cp = new ChangePassword(usernameTextBox.Text);
                        cp.Show();
                    }

                    this.Hide();
                    MDIParent1 mdi = new MDIParent1(user.rank, usernameTextBox.Text);
                    mdi.Show();
                    //((Form)MDIParent1).Controls["statusLabel"].Text = user.rank;
                }
                else
                {
                    MessageBox.Show("Username and Password do not match");
                }
                
            }
            else
            {
                MessageBox.Show("Username and Password not registerd");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
