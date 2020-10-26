using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace inst
{
    class Instrument
    {
        public string Name { get; set; }
        public ObservableCollection<Mark> Marks {get;set;}
        public Instrument(string Name, params Mark [] list)
        {
            this.Name = Name;
            Marks = new ObservableCollection<Mark>();
            foreach (Mark i in list)
            {
                Marks.Add(i);
            }
        }
    }
}
