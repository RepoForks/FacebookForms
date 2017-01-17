﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FBPlay
{
    public partial class PostView : InstrumentedGrid
    {
        public PostView()
        {
            InitializeComponent();
            //https://tctechcrunch2011.files.wordpress.com/2016/02/facebook-reactions-animation.gif?w=1348&h=388
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (likeArea.TranslationY == -50)
            {
                likeArea.TranslateTo(0, 0, 100, Easing.BounceIn);
                await Task.Delay(50);
                likeArea.FadeTo(0, 50);
            }
            else
            {
                likeArea.FadeTo(1d, 20);
                likeArea.TranslateTo(0, -50, 100, Easing.BounceOut);
            }
        }
    }
}
