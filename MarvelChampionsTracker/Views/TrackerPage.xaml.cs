using System;
using System.Collections.Generic;
using Plugin.DeviceOrientation;
using Plugin.DeviceOrientation.Abstractions;
using Xamarin.Forms;

namespace MarvelChampionsTracker.Views
{
    public partial class TrackerPage : ContentPage
    {

        DeviceOrientations CurrentOrientation { get; }

        public TrackerPage()
        {
            InitializeComponent();

            CrossDeviceOrientation.Current.LockOrientation(DeviceOrientations.Landscape);
        }
    }
}
