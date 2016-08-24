using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        async void Button_OnClicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
