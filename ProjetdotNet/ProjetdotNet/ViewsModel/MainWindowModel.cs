using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetdotNet
{
    class MainWindowViewModel  
    {

        public ObservableCollection<string> Optiontypes { get; private set; }

        public MainWindowViewModel()
        {
            Optiontypes = new ObservableCollection<string>();
            Optiontypes.Add("Basket");
            Optiontypes.Add("vanilla Call"); 
            
        }
    }
}
