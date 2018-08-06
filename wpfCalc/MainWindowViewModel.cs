using System.ComponentModel;
using System.Runtime.CompilerServices;
using wpfCalc.Annotations;

namespace wpfCalc
{
    internal sealed class MainWindowViewModel
    {
        private string title;

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}