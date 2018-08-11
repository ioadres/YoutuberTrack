using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutuberTrack.Core;
using YoutuberTrack.Users.Components.Splash;
using YoutuberTrack.Users.Components.Login;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YoutuberTrack.Users
{
    public partial class App  : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(PageRoutes.GetKey<LoginPage>());
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {     
            containerRegistry.RegisterForNavigation<SplashPage>();
            containerRegistry.RegisterForNavigation<LoginPage>();

            PageRoutes.AddKey<SplashPage>($"/{nameof(SplashPage)}");

            PageRoutes.AddKey<LoginPage>($"/{nameof(LoginPage)}");
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
