using ECommerceApp.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ECommerceApp.ViewModels
{
    public class MenuItemViewModel
    {
        #region Atributes
        private NavigationService navigationService;
        #endregion
        #region properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion
        #region Constructors
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }
        #endregion

        #region Command
        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand
                    (
                        async () =>
                        {
                            await Navigate();
                        }
                    );
            }
        }

        private async Task Navigate()
        {
            await navigationService.Navigate(PageName);
        }
        #endregion
    }
}
