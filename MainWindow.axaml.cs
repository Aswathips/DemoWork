using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DemoApp
{
    public partial class MainWindow : Window
    {
        Button btn1;

        public MainWindow()
        {
            InitializeComponent();
            btn1 = this.Find<Button>("click");
        }


//separate method
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            LoginForm form = new();
            form.Show();
            this.Close();   
        }
    }
}
