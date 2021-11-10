using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MarvelChampionsTracker.Views.Controls
{
    public partial class CardView : ContentView
    {

        public static readonly BindableProperty CardValueProperty = BindableProperty.Create(
        nameof(CardValue),
        typeof(int),
        typeof(CardView),
        0);

        public int CardValue
        {
            get => (int)GetValue(CardView.CardValueProperty);
            set => SetValue(CardView.CardValueProperty, value);
        }


        public CardView()
        {
            InitializeComponent();
        }
    }
}
