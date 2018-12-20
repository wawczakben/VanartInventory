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
    public partial class PartList : Form
    {
        FBConnection fb = new FBConnection();
        DataTable dt = new DataTable();

        public PartList()
        {
            InitializeComponent();
        }

        private void PartList_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Company");
            dt.Columns.Add("Part Number");
            dt.Columns.Add("Current Stock");
            dt.Columns.Add("id");

            dataGridView1.DataSource = dt;

            fillTable();

        }

        private async void fillTable()
        {
            dt.Rows.Clear();
            FirebaseResponse response = await fb.client.GetAsync("parts/counter/");
            Counter c = response.ResultAs<Counter>();
            //string c = response.Body;
            int count = Convert.ToInt32(c.count);

            for(int i = 0; i < count; i++)
            {
                try
                {
                    FirebaseResponse response2 = await fb.client.GetAsync("parts/" + (i + 1));
                    Part part = response2.ResultAs<Part>();

                    FirebaseResponse response3 = await fb.client.GetAsync("history/" + part.history);
                    History history = response3.ResultAs<History>();

                    FirebaseResponse response4 = await fb.client.GetAsync("companies/" + part.company);
                    Company company = response4.ResultAs<Company>();

                    DataRow row = dt.NewRow();
                    row["Company"] = company.name;
                    row["Part Number"] = part.partNum;
                    row["Current Stock"] = history.currentStock;
                    row["id"] = (i + 1);

                    dt.Rows.Add(row);
                }
                catch
                {
                    //nothing here for now
                }
            }

        }

        private void viewInfoButton_Click(object sender, EventArgs e)
        {
            //hide part list
            //PartList.ActiveForm.Hide();

            //pull data from dataGridView
            int row = dataGridView1.CurrentCell.RowIndex;
           // MessageBox.Show(row.ToString());
            if(row >= 0)
            {
                string company = dataGridView1[0, row].Value.ToString();
                string partNum = dataGridView1[1, row].Value.ToString();
                MessageBox.Show("company: " + company + " - partNum: " + partNum);

                //open a new window with that data called Part Information
            }
            else
            {
                MessageBox.Show("You must select a part from the list!");
            }
          
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private async void updateStockButton_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            if (row >= 0)
            {
                string partID = dataGridView1[3, row].Value.ToString();

                History history = new History
                {
                    currentStock = ((Convert.ToInt32(dataGridView1[2, row].Value.ToString())) + (Convert.ToInt32(textBox1.Text))).ToString(),
                };
              
                FirebaseResponse updateResponse = await fb.client.UpdateAsync("history/" + partID, history);
                dataGridView1[2, row].Value = history.currentStock;

                //open a new window with that data called Part Information
            }
            else
            {
                MessageBox.Show("You must select a part from the list!");
            }

           // fillTable();

        }
    }
}
