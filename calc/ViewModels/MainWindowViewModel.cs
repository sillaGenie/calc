using calc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using calc.Models;

namespace calc.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private float number1;
        public float Number1
        {
            get => number1;
            set
            {
                number1 = value;
                OnPropertyChanged();
            }
        }
        private float number2;
        public float Number2
        {
            get => number2;
            set
            {
                number2 = value;
                OnPropertyChanged();
            }
        }
        private float number3;
        public float Number3
        {
            get => number3;
            set
            {
                number3 = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Number3 = Ariph.Add(Number1, Number2);
        }

        private bool CanAddCommandExecuted(object p)
        {
            if (Number1 != 0 || Number2 != 0)
                return true;
            else
                return
                    false;
        }

        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
            SubCommand = new RelayCommand(OnSubCommandExecute, CanAddCommandExecuted);
            MultCommand = new RelayCommand(OnMultCommandExecute, CanAddCommandExecuted);
            DivCommand = new RelayCommand(OnDivCommandExecute, CanDivCommandExecuted);
        }

        public ICommand SubCommand { get; }
        private void OnSubCommandExecute(object p)
        {
            Number3 = Ariph.Remove(Number1, Number2);
        }

        public ICommand MultCommand { get; }
        private void OnMultCommandExecute(object p)
        {
            Number3 = Ariph.Multiply(Number1, Number2);
        }
        public ICommand DivCommand { get; }
        private void OnDivCommandExecute(object p)
        {
            Number3 = Ariph.Division(Number1, Number2);
        }
        private bool CanDivCommandExecuted(object p)
        {
            if ( Number2 != 0)
                return true;
            else
                return
                    false;
        }
    }

}
