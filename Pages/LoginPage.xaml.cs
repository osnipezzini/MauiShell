using Microsoft.Maui.Controls;

using System;

namespace MauiShell.Pages
{
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//MainPage");
        }
    }
}