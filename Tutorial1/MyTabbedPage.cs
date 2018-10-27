using System;
using Tutorial1.Views;
using Xamarin.Forms;
namespace Tutorial1
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new TabPage1());
            Children.Add(new TabPage2());
        }
    }
}
