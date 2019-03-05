using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace VanartInventoryWPF
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
                System.Windows.MessageBox.Show("There was an error connecting to the databse.");
            }

        }
    }
}
