using System;
using Xamarin.Forms;

namespace DevProtocol.Xam.Demos.SpaceNav.Controls
{
    public class SpaceNavigationPage: NavigationPage
    {
		public SpaceNavigationPage(Page root):base(root)
        {
			BarBackgroundColor = Color.DarkBlue;
			BarTextColor = Color.White;
		}
    }
}
