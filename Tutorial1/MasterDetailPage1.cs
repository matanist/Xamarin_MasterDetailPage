using System;
using Tutorial1.Views;
using Xamarin.Forms;

namespace Tutorial1
{
    public class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            Master = new MyMasterPage();
            Detail = new NavigationPage(new MyDetailPage());
        }
    }
}
