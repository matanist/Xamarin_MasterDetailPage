using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutorial1.Views
{
    public partial class MyMasterPage : ContentPage
    {
        public MyMasterPage()
        {
            InitializeComponent();
            Icon = "hamburger.png";
        }
        public void btnClicked(object sender, EventArgs eventArgs)
        {
            var masterdetailPage = (MasterDetailPage)App.Current.MainPage;
            var content = (Button)sender;
            masterdetailPage.Detail = new NavigationPage(new NewDetailPage(content.Text, content));
            masterdetailPage.IsPresented = false;
        }
        public void btnTabbedClicked(object sender, EventArgs eventArgs)
        {
            var masterdetailPage = (MasterDetailPage)App.Current.MainPage;
            masterdetailPage.Detail = new NavigationPage(new MyTabbedPage());
            masterdetailPage.IsPresented = false;
        }
    }
}
