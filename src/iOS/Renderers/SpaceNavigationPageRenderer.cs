using System;
using DevProtocol.Xam.Demos.SpaceNav.Controls;
using DevProtocol.Xam.Demos.SpaceNav.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SpaceNavigationPage), typeof(SpaceNavigationPageRenderer))]
namespace DevProtocol.Xam.Demos.SpaceNav.iOS.Renderers
{
    public class SpaceNavigationPageRenderer: NavigationRenderer
    {
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				var att = new UITextAttributes();
				att.Font = UIFont.FromName("Space Age", 24);
				UINavigationBar.Appearance.SetTitleTextAttributes(att);
			}
		}
    }
}
