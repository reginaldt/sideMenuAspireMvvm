using System;
using System.Collections.Generic;
using SideMenuAspireMvvm.Models;
using MvvmAspire;

namespace SideMenuAspireMvvm.ViewModels
{
    public class MasterNavigationPageViewModel : AppViewModel
    {
        public List<Menu> MenuList { get; set; }
        public RelayCommand<Menu> SelectedMenuCommand { get; set; }

        private Menu _selectedMenu;
        public Menu SelectedMenu
        {
            get { return _selectedMenu; }
            set
            {
                SetProperty(ref _selectedMenu, value);
                if (value != null)
                    SelectedMenuCommand.Execute(value);

            }
        }

        private Boolean _isMenuVisible;
        public Boolean IsMenuVisible
        {
            get { return _isMenuVisible; }
            set 
            {
                SetProperty(ref _isMenuVisible, value);      
            }
        }

        public MasterNavigationPageViewModel()
        {
            MenuList = new List<Menu>{
                new Menu { Name = "Home", Code = "mnu_home"},
                new Menu { Name = "About", Code = "mnu_about"}
            };


            SelectedMenuCommand = new RelayCommand<Menu>(async (menu) =>
            {
                SelectedMenuCommand.CanRun = false;

                if (menu.Code == "mnu_home")
                {
                    await Navigation.SetDetailPageAsync<HomeViewModel>(true);

                }
                else if (menu.Code == "mnu_about")
                {
                    await Navigation.SetDetailPageAsync<AboutViewModel>(true);
                }

                IsMenuVisible = false;
                SelectedMenuCommand.CanRun = true;
            });

        }
            

    }
}
