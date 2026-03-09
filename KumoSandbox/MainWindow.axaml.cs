using Avalonia.Controls;
using Avalonia.Media;

namespace KumoSandbox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MeText.Text = FontManager.Current.DefaultFontFamily.Name;
        }
    }
}