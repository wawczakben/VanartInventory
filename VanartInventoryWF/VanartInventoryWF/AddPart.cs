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
    public partial class AddPart : Form
    {
        FBConnection fb = new FBConnection();

        public AddPart()
        {
            InitializeComponent();
        }

        private async void AddPart_Load(object sender, EventArgs e)
        {
            FirebaseResponse response = await fb.client.GetAsync("companies/counter/");
            Counter counter = response.ResultAs<Counter>();
            int count = Convert.ToInt32(counter.count);

            for (int i = 0; i < count; i++)
            {
                try
                {
                    FirebaseResponse response2 = await fb.client.GetAsync("companies/" + (i + 1));
                    Company company = response2.ResultAs<Company>();

                    CompanyComboBox.Items.Add(company.name);
                }
                catch
                {
                    //nothing here for now
                }
            }

            response = await fb.client.GetAsync("material/counter/");
            counter = response.ResultAs<Counter>();
            count = Convert.ToInt32(counter.count);

            for (int i = 0; i < count; i++)
            {
                try
                {
                    FirebaseResponse response2 = await fb.client.GetAsync("material/" + (i + 1));
                    Material mat = response2.ResultAs<Material>();

                    materialComboBox.Items.Add("Steel " + (i + 1));
                }
                catch
                {

                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Part newPart = new Part
            {
                company = CompanyComboBox.Text,
                history = "000",
                //material = materialComboBox.Text,
                material = "1",
                partNum = partNumBox.Text,
                pounds1000 = Pounds1000Box.Text
            };

            //UPDATE PART COUNT
            FirebaseResponse updateCount = await fb.client.GetAsync("parts/counter/");
            Counter count = updateCount.ResultAs<Counter>();
            int c = Convert.ToInt32(count.count);
            c++;

            Counter counter = new Counter
            {
                count = c.ToString()
            };

            FirebaseResponse updateCount2 = await fb.client.UpdateAsync("parts/counter", counter);

            //UPDATE HISTORY COUNT
            updateCount = await fb.client.GetAsync("history/counter/");
            Counter count2 = updateCount.ResultAs<Counter>();
            int c2 = Convert.ToInt32(count2.count);
            c2++;
   

            Counter counter2 = new Counter
            {
                count = c2.ToString()
            };

            updateCount2 = await fb.client.UpdateAsync("history/counter", counter2);

            newPart.history = c.ToString();
            if (newPart.company == "PNC")
                newPart.company = "1";
            else if (newPart.company == "Carthage")
                newPart.company = "2";


            FirebaseResponse response = await fb.client.SetAsync("parts/" + counter.count, newPart);

            History his = new History
            {
                currentStock = "0"
            };

            response = await fb.client.SetAsync("history/" + counter2.count, his);


            this.Dispose();
        }
    }
}
