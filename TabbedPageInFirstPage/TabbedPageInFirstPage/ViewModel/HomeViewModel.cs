using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TabbedPageInFirstPage.Views;
using Xamarin.Forms;

namespace TabbedPageInFirstPage.ViewModel
{
  public class HomeViewModel
  {
    public ICommand ClickCommand { get; set; }
    public HomeViewModel()
    {
      ClickCommand=new Command(ClickCommandExcute);
    }

    private void ClickCommandExcute(object obj)
    {
      App.Current.MainPage.Navigation.PushModalAsync(new DetailPage(),false);
    }
  }
}
