using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace VanartInventoryWF
{
    class FBConnection
    {

        public IFirebaseClient client { get; set; }

        public FBConnection()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "81FSx233fyDWWBRDsWfLe5bJogkg2l56ZBGhlZ4o",
                BasePath = "https://vanart-inventory.firebaseio.com/"
            };

            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("There was an error connecting to the databse");
            }

        }
    }
}
