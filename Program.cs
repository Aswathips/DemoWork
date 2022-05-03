using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using System;
using System.Diagnostics;
using System.IO;

namespace DemoApp
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            string dir = @"E:\temp\Demo";
            if (Directory.Exists(dir))
            {
                Debug.WriteLine("Directory exists");
                LoginForm form = new();        //Throw Exception.
                                               //Could not CreateWindow(): IWindowingPlatform is not registered.
                form.Show();                             
            }
            else
            {
                Debug.WriteLine("Directory not exists");
                BuildAvaloniaApp()
                 .StartWithClassicDesktopLifetime(args);
               
            }
        }
           

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
