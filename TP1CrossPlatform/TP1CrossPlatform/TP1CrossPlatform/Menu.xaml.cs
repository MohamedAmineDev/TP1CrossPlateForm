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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            logout.Clicked += (sender, e) =>
            {
                Login login = new Login();
                Navigation.PushModalAsync(login);
            };
            btnMaster.Clicked += (sender, e) => {
                Front front = new Front();
                Navigation.PushModalAsync(front);
            };
            btnTabbed.Clicked += (sender, e) => {
                Tabbed tabbed = new Tabbed();
                Navigation.PushModalAsync(tabbed);
            };
            btnCarousel.Clicked += (sender, e) => {
                Courasol courasol = new Courasol();
                Navigation.PushModalAsync(courasol);
            };
        }
    }
}