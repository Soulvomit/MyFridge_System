﻿using Microsoft.Extensions.Logging;
using MyFridge_UserInterface_MAUI.Service;

namespace MyFridge_UserInterface_MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });         
#if DEBUG
		    builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}