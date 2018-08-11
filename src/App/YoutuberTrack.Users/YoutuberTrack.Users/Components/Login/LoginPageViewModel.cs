using System;
using Prism.Navigation;
using YoutuberTrack.Core.Base;

namespace YoutuberTrack.Users.Components.Login
{
    public class LoginPageViewModel: ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Login";
        }
    }
}
