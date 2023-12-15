using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ms_bb
{
    public partial class MainPage : ContentPage
    {
        private List<Images> images;
        private bool IsStarted = true;
        private int actualPosition; 
        public MainPage()
        {
            InitializeComponent();

            images = new List<Images>
            {
                new Images { ImageSource = "forest.jpg", ImageName="forest"},
                new Images { ImageSource = "las1.jpg", ImageName="forest"},
                new Images { ImageSource = "las3.jpg", ImageName="forest"},
                new Images { ImageSource = "las3.jpg", ImageName="forest"},
            };
            imagesCarousel.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                if (IsStarted)
                {
                    SlideImages();
                }

                return true;
            });
        }

        void SlideImages()
        {
            actualPosition = (actualPosition + 1) % images.Count;
            imagesCarousel.Position = actualPosition;
        }

        private void AutoSlideManager(object sender, EventArgs e)
        {
            IsStarted = !IsStarted;
            startStopButton.Text = IsStarted ? "Stop Auto Slide" : "Start Auto Slide";
        }
    }
}
