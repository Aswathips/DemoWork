using System.Diagnostics;
using System.IO;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace DemoApp
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                string dir = @"E:\temp\Demo";
                if (!Directory.Exists(dir))
                {
                    Debug.WriteLine("Directory exists");
                    LoginForm login = new(); 
                    login.Show();                             
                }
                else
                {
                    Debug.WriteLine("Directory not exists");
                    desktop.MainWindow = new MainWindow();
                }
                
                
                desktop.ShutdownMode = Avalonia.Controls.ShutdownMode.OnLastWindowClose;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
