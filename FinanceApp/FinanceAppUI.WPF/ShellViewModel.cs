using CommunityToolkit.Mvvm.ComponentModel;
using FinanceAppUI.WPF.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAppUI.WPF
{
    public partial class ShellViewModel : ObservableObject
    {
        public ShellViewModel(HomePageViewModel homePageViewModel)
        {
            ActiveItem = homePageViewModel;
        }

        [ObservableProperty]
        private object? activeItem;
    }
}
