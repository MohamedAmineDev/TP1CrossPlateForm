using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1CrossPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Clicked += (sender, e) =>
            {
                if (username.Text == "amine" && password.Text == "123")
                {
                    Menu menu = new Menu();
                    Navigation.PushModalAsync(menu);
                    username.Text = "";
                    password.Text = "";
                }
                else if (username.Text != "amine" && password.Text == "123")
                {
                    message.Text = "Le nom de l'utlisateur est incorrecte !";
                    Device.StartTimer(TimeSpan.FromSeconds(30), () =>
                    {
                        // Do something
                        message.Text = "";

                        return false; // True = Repeat again, False = Stop the timer
                    });
                }
                else if (username.Text == "amine" && password.Text != "123")
                {
                    message.Text = "Le mot de passe est incorrecte !";
                    Device.StartTimer(TimeSpan.FromSeconds(30), () =>
                    {
                        // Do something
                        message.Text = "";

                        return false; // True = Repeat again, False = Stop the timer
                    });
                }
                else
                {
                    message.Text = "Le mot de passe et le nom de l'utilisateur sont incorrectes !";
                    Device.StartTimer(TimeSpan.FromSeconds(30), () =>
                    {
                        // Do something
                        message.Text = "";

                        return false; // True = Repeat again, False = Stop the timer
                    });
                }

            };
        }


        /*try { Navigation.PushAsync(new Menu()); }
        catch(Exception k)
        {
            System.Console.WriteLine(k.ToString());
        }*/

    }

}
