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
    public partial class Tabbed : TabbedPage
    {
        public Tabbed()
        {
            InitializeComponent();
            goBack.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
            };
            goBack2.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
            };
            goBack3.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
            };
            goBack4.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
            };

            logout.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
                Navigation.PopModalAsync();
            };
            logout2.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
                Navigation.PopModalAsync();
            };
            logout3.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
                Navigation.PopModalAsync();
            };
            logout4.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
                Navigation.PopModalAsync();
            };
        }
    }
}