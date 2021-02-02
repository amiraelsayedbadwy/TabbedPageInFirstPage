using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TabbedPageInFirstPage.Controls;
using TabbedPageInFirstPage.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(MyTabbedPage), typeof(TabbedRendererForiOS))]
namespace TabbedPageInFirstPage.iOS.Renderer
{
  public class TabbedRendererForiOS : TabbedRenderer
  {
    protected override void OnElementChanged(VisualElementChangedEventArgs e)
    {
      base.OnElementChanged(e);

      Element.PropertyChanged+=Element_PropertyChanged;
    }

    private void Element_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      if(e.PropertyName=="IsHidden")
      {
        if((Element as MyTabbedPage).IsHidden)
        {
          TabBar.Hidden=true;
        }
        else
        {
          TabBar.Hidden=false;
        }
      }
    }
  }
}
