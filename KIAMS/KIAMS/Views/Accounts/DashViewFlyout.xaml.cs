using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KIAMS.Views.Accounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashViewFlyout : ContentPage
    {
        public ListView ListView;

        public DashViewFlyout()
        {
            InitializeComponent();

            BindingContext = new DashViewFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class DashViewFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DashViewFlyoutMenuItem> MenuItems { get; set; }

            public DashViewFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<DashViewFlyoutMenuItem>(new[]
                {
                    new DashViewFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new DashViewFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new DashViewFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new DashViewFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new DashViewFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}