using MauiShell.ViewModels;

using Microsoft.Maui.Essentials;

using System;

namespace MauiShell.Pages
{
    public partial class MainPage
    {
        int count = 0;

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
