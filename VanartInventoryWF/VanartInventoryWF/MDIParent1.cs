using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanartInventoryWF
{
    public partial class MDIParent1 : Form
    {
        // private int childFormNumber = 0;
        string username;

        public MDIParent1(string role, string user)
        {
            InitializeComponent();
            statusLabel.Text = role;
            username = user;
            if(statusLabel.Text != "admin")
            {
                addPartToolStripMenuItem.Visible = false;
                addCompanyToolStripMenuItem.Visible = false;
                addUserToolStripMenuItem.Visible = false;
            }
        }

        private void partListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartList partList = new PartList();
            partList.MdiParent = this;
            partList.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.MdiParent = this;
            addUser.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // nothing
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(username);
            cp.MdiParent = this;
            cp.Show();

        }

        private void addPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.MdiParent = this;
            addPart.Show();
        }
    }
}
