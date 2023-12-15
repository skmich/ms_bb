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
        public MainPage()
        {
            InitializeComponent();

            images = new List<Images>
            {
                new Images { ImgageSource = "forest,jpg", ImageName="forest"},
                new Images { ImgageSource = "forest,jpg", ImageName="forest"},
                new Images { ImgageSource = "forest,jpg", ImageName="forest"},
            };

            
        }
    }
}
