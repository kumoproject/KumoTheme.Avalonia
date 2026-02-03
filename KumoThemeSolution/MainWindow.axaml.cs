using Avalonia.Controls;
using Avalonia.Media;

namespace KumoThemeSolution
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // 逻辑：如果是红色就变蓝色，反之亦然
            var currentBrush = this.Resources["MyColor"] as SolidColorBrush;

            if (currentBrush?.Color == Colors.Red)
            {
                this.Resources["MyColor"] = new SolidColorBrush(Colors.DodgerBlue);
            }
            else
            {
                this.Resources["MyColor"] = new SolidColorBrush(Colors.Red);
            }
        }
    }
}