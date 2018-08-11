using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;
using YoutuberTrack.Core.Base;

namespace AppTokiota.Users.Components.Splash
{
    public class SplashPageViewModel : ViewModelBase
    {
        public SplashPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Splash";
        }
    }
}