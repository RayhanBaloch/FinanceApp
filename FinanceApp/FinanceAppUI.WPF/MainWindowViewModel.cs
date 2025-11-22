using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAppUI.WPF;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = "Finance App";
}
