using System;
using TabbedPageInFirstPage.Controls;
using TabbedPageInFirstPage.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace TabbedPageInFirstPage
{
  public partial class App : Xamarin.Forms.Application
  {
    public App()
    {
      InitializeComponent();

      LoadTabbedPage();
    }

    protected override void OnStart()
    {
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
    public  void LoadTabbedPage()
    {
      MyTabbedPage tabbedPage = new MyTabbedPage();
      tabbedPage.On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
      tabbedPage.FlowDirection=FlowDirection.RightToLeft;
      var firstTab = new MyNavigationPage(new HomePage()) { Title="Home" };
      var secondTab = new MyNavigationPage(new ProfilePage()) { Title=" Profile"};
      tabbedPage.Children.Add(firstTab);
      tabbedPage.Children.Add(secondTab);
      App.Current.MainPage=tabbedPage;
    }
  }
}
