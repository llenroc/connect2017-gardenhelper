﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace GardenHelper.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("com.xamarin.gardenhelper")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .InstalledApp("com.julmar.gardenhelper")
                .StartApp();
        }
    }
}

