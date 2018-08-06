using System.ComponentModel;
using System.Runtime.CompilerServices;
using CalculatorScope;
using wpfCalc.Annotations;

namespace wpfCalc.ViewModels
{
    internal sealed class CalculatorViewModel : INotifyPropertyChanged
    {
        // TODO: Как думаешь зачем тут этот парень? И что с ним нужно делать?
        private Calculator _calculator;

        public CalculatorViewModel()
        {
            _calculator = new Calculator();
        }

        // TODO: Читать вначале: 
        // https://habr.com/post/338518/
        // https://metanit.com/sharp/wpf/22.1.php
        // http://kindelephant.blogspot.com/2011/03/mvvm.html
        // https://metanit.com/sharp/wpf/11.php
        // https://metanit.com/sharp/wpf/11.2.php
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}