using System;

namespace MauiShell
{
    public partial class AppShell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//LoginPage");
        }
    }
}
