using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TabbedPageInFirstPage.Controls
{
  public class MyTabbedPage : TabbedPage
  {
    public static readonly BindableProperty IsHiddenProperty = BindableProperty.Create("IsHidden", typeof(bool), typeof(MyTabbedPage), false);
    public MyTabbedPage()
    {
      CurrentPage=Children.LastOrDefault();
      // FlowDirection = FlowDirection.RightToLeft;
    }
    public bool IsHidden
    {
      set { SetValue(IsHiddenProperty, value); }
      get { return (bool)GetValue(IsHiddenProperty); }
    }
  }
}
