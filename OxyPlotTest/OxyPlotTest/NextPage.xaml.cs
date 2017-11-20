using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OxyPlotTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
        }

        private async void ToPrevPage(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}