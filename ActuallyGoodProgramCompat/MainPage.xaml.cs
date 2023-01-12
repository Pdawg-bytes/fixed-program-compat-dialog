using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using System.Diagnostics;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.System;

namespace ActuallyGoodProgramCompat
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ProgramCompat dialog = new ProgramCompat();
            await dialog.ShowAsync();

            if (dialog.Result == NotifResult.LearnMore)
            {
                await Launcher.LaunchUriAsync(new Uri("https://www.youtube.com/watch?v=dQw4w9WgXcQ"));
            }
        }

        private void RadioButtonLight_Click(object sender, RoutedEventArgs e)
        {
            this.RequestedTheme = ElementTheme.Light;
            ProgramCompat.theme = ElementTheme.Light;
        }

        private void RadioButtonDark_Click(object sender, RoutedEventArgs e)
        {
            this.RequestedTheme = ElementTheme.Dark;
            ProgramCompat.theme = ElementTheme.Dark;
        }
    }
}
