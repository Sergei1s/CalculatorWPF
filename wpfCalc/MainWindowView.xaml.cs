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

        private void ButtonBase_OnClick_Plus(object sender, RoutedEventArgs e)
        {
            ///try{
            ///
            /// if (actionhappanned = true)
            ///     return a + b;............
            ///    } 
            /// catch{(exeption)}   
        }

        private void CalculatorView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}