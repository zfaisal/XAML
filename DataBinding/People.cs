using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBinding
{
    public class People: INotifyPropertyChanged
    {
        private Person pP;

        public Person p
        {
            get { return pP; }
            set
            {
        
                pP = value;
                OnPropertyChanged("p"); 
            }
        }

        
        public static People GetPeople(int d)
        {
            People ppl = new People();
            ppl.p = new Person();
            ppl.p.Id = d;
            return ppl;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

    }
}
