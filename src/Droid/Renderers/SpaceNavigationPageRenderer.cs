using System;
using Android.Graphics;
using DevProtocol.Xam.Demos.SpaceNav.Controls;
using DevProtocol.Xam.Demos.SpaceNav.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(SpaceNavigationPage), typeof(SpaceNavigationPageRenderer))]
namespace DevProtocol.Xam.Demos.SpaceNav.Droid.Renderers
{
    public class SpaceNavigationPageRenderer: NavigationPageRenderer
    {
        private Android.Support.V7.Widget.Toolbar toolbar;
		
        public override void OnViewAdded(Android.Views.View child)
		{
			base.OnViewAdded(child);
			if (child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
			{
				toolbar = (Android.Support.V7.Widget.Toolbar)child;
				toolbar.ChildViewAdded += Toolbar_ChildViewAdded;
			}
		}

		void Toolbar_ChildViewAdded(object sender, ChildViewAddedEventArgs e)
		{
			var view = e.Child.GetType();

            if(e.Child.GetType() == typeof(Android.Widget.TextView))
            {
                var textView = (Android.Widget.TextView)e.Child;
                var spaceFont = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "space_age.ttf");
                textView.Typeface = spaceFont;
                toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
            }
            // If your app is not using the AppCompatTextView, you don't need this check
			if (e.Child.GetType() == typeof(Android.Support.V7.Widget.AppCompatTextView))
			{
				var textView = (Android.Support.V7.Widget.AppCompatTextView)e.Child;
				var spaceFont = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "space_age.ttf");
				textView.Typeface = spaceFont;
				toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
			}
		}


    }
}
