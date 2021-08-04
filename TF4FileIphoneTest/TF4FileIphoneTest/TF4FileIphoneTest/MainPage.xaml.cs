using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF4FileIphoneTest.T4;
using Xamarin.Forms;

namespace TF4FileIphoneTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyLabel.Text = AppResources.Key;
        }
    }
}
