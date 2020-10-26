using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inst
{
    class Operation
    {
        public string Name { get; set; }
        public ObservableCollection<Instrument> Instruments { get; set; }
        public Operation(string Name, params Instrument[] list)
        {
            this.Name = Name;
            Instruments = new ObservableCollection<Instrument>();
            foreach (Instrument i in list)
            {
                Instruments.Add(i);
            }
        }
    }
}
