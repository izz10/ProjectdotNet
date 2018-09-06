using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;

namespace ProjetdotNet
{
    class MainWindowViewModel  
    {
        private double strike;

        private double maturity;

        private string share_name;

        public ObservableCollection<string> Optiontypes { get; private set; }

        public ObservableCollection<string> DataType{ get; private set; }

        public DelegateCommand ExecuteCommand { get; private set; }

        public double Strike
        {
            get
            {
                return strike;
            }
            set
            {
                
            }
        }

        public MainWindowViewModel()
        {
            Optiontypes = new ObservableCollection<string>();
            DataType = new ObservableCollection<string>();
            Optiontypes.Add("Basket");
            Optiontypes.Add("vanilla Call");
            DataType.Add("Simulated");
            DataType.Add("Historical");

            ExecuteCommand = new DelegateCommand(ExtractComponents);

        }
        private void ExtractComponents()
        {           
         Console.WriteLine("Hello World");
        }
    }
}
