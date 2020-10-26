using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace inst
{
    class ViewModel : INotifyPropertyChanged
    {
        static MillingCoef Coef = new MillingCoef();
        Model mod = new Model();
        #region точение
        public double CuttingDepthViewModel
        {
            get
            {
                return mod.CuttingDepth;
            }
            set
            {
                mod.CuttingDepth = value;
                RaisePropertyChanged("CuttingDepthViewModel");

            }
        }

        public double FeedViewModel
        {
            get
            {
                return mod.Feed;
            }
            set
            {
                mod.Feed = value;
                RaisePropertyChanged("FeedViewModel");

            }
        }
        public double TenacityViewModel
        {
            get
            {
                return mod.Tenacity;
            }
            set
            {
                mod.Tenacity = value;
                RaisePropertyChanged("TenacityViewModel");

            }
        }
        public double CoefKViewModel
        {
            get
            {
                return mod.CoefK;
            }
            set
            {
                mod.CoefK = value;
                RaisePropertyChanged("CoefKViewModel");

            }
        }
        public double CoefCViewModel
        {
            get
            {
                return mod.CoefC;
            }
            set
            {
                mod.CoefC = value;
                RaisePropertyChanged("CoefCViewModel");

            }
        }
        public double XViewModel
        {
            get
            {
                return mod.X;
            }
            set
            {
                mod.X = value;
                RaisePropertyChanged("XViewModel");


            }
        }
        public double MViewModel
        {
            get
            {
                return mod.M;
            }
            set
            {
                mod.M = value;
                RaisePropertyChanged("MViewModel");


            }
        }
        public double YViewModel
        {
            get
            {
                return mod.Y;
            }
            set
            {
                mod.Y = value;
                RaisePropertyChanged("YViewModel");


            }
        }
        public double ResultViewModel
        {
            get
            {
                return mod.Result;
            }
            set
            {
                mod.Result = value;
                RaisePropertyChanged("ResultViewModel");
            }

        }
        public void GetResult()
        {
            ResultViewModel = mod.Calculate();
        }
        #endregion
        public ObservableCollection<Operation> OperationList { get; set; } = Coef.OperationList;

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));

            }
        }
        public static ICommand PressCommand { get; } = new RoutedCommand(nameof(PressCommand), typeof(ViewModel));
        static ViewModel()
        {
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(PressCommand, OnPressExecute, CanExecute));

        }
        private static void CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private static void OnPressExecute(object sender, ExecutedRoutedEventArgs e)
        {
            var view = (ViewModel)e.Parameter;
            view.GetResult();
        }

    }
}
