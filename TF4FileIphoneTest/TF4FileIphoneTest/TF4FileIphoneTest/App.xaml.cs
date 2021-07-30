using System;
using System.ComponentModel;
using TF4FileIphoneTest.T4;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF4FileIphoneTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); 
            InitializeLocalizationResourceManager();
            MainPage = new MainPage();
        }
        private void InitializeLocalizationResourceManager()
        {
            LocalizationResourceManager.Current.PropertyChanged -= LanguageChanged;
            LocalizationResourceManager.Current.PropertyChanged += LanguageChanged;
            LocalizationResourceManager.Current.Init(AppResources.ResourceManager);
        }

        private void LanguageChanged(object sender, PropertyChangedEventArgs e)
        {
            AppResources.Culture = LocalizationResourceManager.Current.CurrentCulture;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
