using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutorial1.Views
{
    public partial class NewDetailPage : ContentPage
    {
        public NewDetailPage(string Content, Button button)
        {
            InitializeComponent();
            lblContent.Text = "Clicked Item Name:" + Content;
            stkContainer.Children.Add(button);
        }

    }
}
