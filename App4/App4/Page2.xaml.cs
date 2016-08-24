using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        async void Button_OnClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        async void Button_OnClicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}
