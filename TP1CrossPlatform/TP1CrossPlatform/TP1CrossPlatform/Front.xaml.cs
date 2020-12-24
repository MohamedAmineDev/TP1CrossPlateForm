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
    public partial class Front : MasterDetailPage
    {
        public Front()
        {
            InitializeComponent();
            goBack.Clicked += (sender, e) => {
                //Menu menu = new Menu();

                Navigation.PopModalAsync();
            };
            logout.Clicked += (sender, e) => {
                //Menu menu = new Menu();
                Navigation.PopModalAsync();
                Navigation.PopModalAsync();
            };
            goBack2.Clicked +=(sender,e)=>{
                Navigation.PopModalAsync();
            };
            logout2.Clicked +=(sender,e)=>{
                Navigation.PopModalAsync();
                Navigation.PopModalAsync();
            };
        }
    }
}