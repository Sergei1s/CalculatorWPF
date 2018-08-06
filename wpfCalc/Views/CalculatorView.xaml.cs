using wpfCalc.ViewModels;

namespace wpfCalc.Views
{
    public partial class CalculatorView
    {
        public CalculatorView()
        {
            InitializeComponent();
            DataContext = new CalculatorViewModel();
        }
    }
}