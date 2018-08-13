using System;
using System.Collections.Generic;
using SideMenuAspireMvvm.Models;
using MvvmAspire;

namespace SideMenuAspireMvvm.ViewModels
{
    public class MasterNavigationPageViewModel : AppViewModel
    {
        public List<Menu> MenuList { get; set; }

        public MasterNavigationPageViewModel()
        {
            MenuList = new List<Menu>{
                new Menu { Name = "Home", Code = "mnu_home"},
                new Menu { Name = "About", Code = "mnu_about"}
            };
        }
    }
}
