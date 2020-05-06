using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDocs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        bool drawBackground;

        public MainPage()
        {
            InitializeComponent();

            //TapGestureRecognizer tap = new TapGestureRecognizer();
            //tap.Tapped += (sender, args) =>
            //{
            //    drawBackground ^= true;
            //    canvasView.
            //};
        }
    }
}
