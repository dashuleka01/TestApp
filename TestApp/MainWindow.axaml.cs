using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace TestApp
{
    public class MainWindow : Window
    {
        private int number1;
        private int number2;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            number1 = 0;
            number2 = 0;
        }

        void Sum(object sender, RoutedEventArgs args)
        {
            number1 = int.Parse(this.FindControl<TextBox>("Number1").Text);
            number2 = int.Parse(this.FindControl<TextBox>("Number2").Text);
            this.FindControl<TextBox>("Number3").Text = (number1 + number2).ToString();
        }
    }
}
