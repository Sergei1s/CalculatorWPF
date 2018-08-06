using System.Windows;

namespace wpfCalc
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel
            {
                Title = "Calculator title"
            };
        }
    }
}