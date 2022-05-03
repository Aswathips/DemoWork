using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DemoApp
{
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
