using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Response;

namespace VanartInventoryWF
{
    public partial class ChangePassword : Form
    {
        FBConnection fb = new FBConnection();
        string user;

        public ChangePassword(string username)
        {
            InitializeComponent();
            user = username;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string newPassword = passwordBox.Text;

            FirebaseResponse response = await fb.client.GetAsync("users/" + user);
            User u = response.ResultAs<User>();

            u.password = newPassword;

            response = await fb.client.UpdateAsync("users/" + user, u);

            this.Dispose();
        }
    }
}
