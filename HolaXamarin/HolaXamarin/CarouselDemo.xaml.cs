﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselDemo : CarouselPage
    {
        public CarouselDemo()
        {
            InitializeComponent();
        }
    }
}