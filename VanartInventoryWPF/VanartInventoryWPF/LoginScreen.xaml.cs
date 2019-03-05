using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using FireSharp.Response;

namespace VanartInventoryWPF
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        FBConnection fb;

        public LoginScreen()
        {
            fb = new FBConnection();
            InitializeComponent();
        }

        private async void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            FirebaseResponse response = await fb.client.GetTaskAsync("users/" + txtUsername.Text);
            User user = response.ResultAs<User>();

            if (response != null)
            {
                //System.Window.MessageBox.Show(user.name);
                if (user.password == txtPassword.Password)
                {

                    if (user.password == "VANART")
                    {
                        //CHANGE THIS 
                        /* MessageBox.Show("You must change your password!");
                        ChangePassword cp = new ChangePassword(usernameTextBox.Text);
                        cp.Show(); */
                    }

                    //open the main window for the user
                    MainWindow mainWindow = new MainWindow(user);
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    errLabel.Content = "Username and Password do not match!";
                }

            }
            else
            {
                errLabel.Content = "Username is not registerd!";
            }
        }

        private void ChkShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            //Currently not working -- looking into a diffrent route
        }
    }
}
