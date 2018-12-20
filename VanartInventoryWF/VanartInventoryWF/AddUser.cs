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
    public partial class AddUser : Form
    {
        FBConnection fb = new FBConnection();

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Here");
        }

        private async void addUserButton_Click(object sender, EventArgs e)
        {
            string username = firstNameBox.Text[0] + lastNameBox.Text;
            username = username.ToLower();
            string Rank = "";
            if(floorButton.Checked)
            {
                Rank = "floor";
            }
            else if(officeButton.Checked)
            {
                Rank = "office";
            }
            else if(adminButton.Checked)
            {
                Rank = "admin";
            }

            User user = new User
            {
                name = firstNameBox.Text,
                password = "VANART",
                rank = Rank,
            };

            FirebaseResponse response = await fb.client.SetAsync("users/" + username, user);
            FirebaseResponse updateCount = await fb.client.GetAsync("users/counter/");
            Counter count = updateCount.ResultAs<Counter>();
            int c = Convert.ToInt32(count.count);
            c++;

            Counter counter = new Counter
            {
                count = c.ToString()
            };

            FirebaseResponse updateCount2 = await fb.client.UpdateAsync("users/counter", counter);

            MessageBox.Show(username + " has been added! Default password is 'VANART'");

            this.Hide();
        }
    }
}
