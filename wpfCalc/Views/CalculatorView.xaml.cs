using wpfCalc.ViewModels;

namespace wpfCalc.Views
{
    public partial class CalculatorView
    {
        private CalculatorViewModel viewModel;
        private int symbolIndex;/// для удаления последнего символа(должен считать и вырезать данную строку без последного символа и вставлять обратно

        public CalculatorView()
        {
            InitializeComponent();
            viewModel = new CalculatorViewModel();
            DataContext = viewModel;
        }

        private void Button_Click_1number(object sender, System.Windows.RoutedEventArgs e)
        {
            viewModel.Number_1 = 1;
            OutputTextBlock.Text = OutputTextBlock.Text+"1";
        }

        private void Button_Click_2number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "2";
        }

        private void Button_Click_3number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "3";
        }

        private void Button_Click_4number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "4";
        }

        private void Button_Click_5number(object sender, System.Windows.RoutedEventArgs e)
        {
            switch (OutputTextBlock.Text)
            {
               case "+":
               OutputTextBlock.Text = "5";
               break;
               case "-":
                    OutputTextBlock.Text = "5";
               break;
               case "*":
                    OutputTextBlock.Text = "5";
               break;
               case "/":
                    OutputTextBlock.Text = "5";
               break;
               default:
                OutputTextBlock.Text = OutputTextBlock.Text + "5";
               break;

            }
           
        }

        private void Button_Click_6number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "6";
        }

        private void Button_Click_7number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "7";
        }

        private void Button_Click_8number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "8";
        }

        private void Button_Click_9number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "9";
        }

        private void Button_Click_0number(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + "0";
        }

        private void Button_Click_PlusSymbol(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = "+";
        }

        private void Button_Click_MinusSymbol(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = "-";
        }

        private void Button_Click_MultiplySymbol(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = "*";
        }

        private void Button_Click_DivideSymbol(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = "/";
        }

        private void Button_Click_DeleteSymbol(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text= OutputTextBlock.Text.Remove(symbolIndex, 1);
        }

        private void Button_Click_SumSymbol(object sender, System.Windows.RoutedEventArgs e)
        {
            OutputTextBlock.Text = "=";
        }
    }
}