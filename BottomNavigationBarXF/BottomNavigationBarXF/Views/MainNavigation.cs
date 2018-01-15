using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottomBar.XamarinForms;
using Xamarin.Forms;

namespace BottomNavigationBarXF.Views
{
    class MainNavigation : BottomBarPage
    {
        public MainNavigation()
        {
            InitPages();
        }

        private void InitPages()
        {
            this.FixedMode = true;
            this.BarTheme = BarThemeTypes.Light;
            this.BarTextColor = Color.FromRgb(222, 198, 157);

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);

            Children.Add(new NavigationPage(new Page1())
            {
                Title = "Home",
                Icon = "ic_action_home.png",
                BarTextColor = Color.FromHex("DEC69D")
            });

            Children.Add(new NavigationPage(new Page2())
            {
                Title = "Music",
                Icon = "ic_action_audiotrack.png",
                BarTextColor = Color.FromHex("DEC69D")
            });

            Children.Add(new NavigationPage(new Page3())
            {
                Title = "Video",
                Icon = "ic_action_videocam.png",
                BarTextColor = Color.FromHex("DEC69D")
            });

            Children.Add(new NavigationPage(new Page4())
            {
                Title = "Page4",
                Icon = "ic_action_home.png",
                BarTextColor = Color.FromHex("DEC69D")
            });

            Children.Add(new NavigationPage(new Page5())
            {
                Title = "Page5",
                Icon = "ic_action_home.png",
                BarTextColor = Color.FromHex("DEC69D")
            });
            
        }
    }
}
