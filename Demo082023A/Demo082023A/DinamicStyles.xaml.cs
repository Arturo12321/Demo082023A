using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo082023A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DinamicStyles : ContentPage
    {
        bool originalStyle = true;
        public DinamicStyles()
        {

            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["searchBarStyle"] = Resources["redSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }
}