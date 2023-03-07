using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KIAMS.Views.Accounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashViewDetail : ContentPage
    {
        public DashViewDetail()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //NavigationPage.HasNavigationBar(this, false);
        }
    }
}