using Microsoft.UI.Xaml.Controls;

using UltraNotes.ViewModels;

namespace UltraNotes.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
