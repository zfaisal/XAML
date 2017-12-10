using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    public class Person : INotifyPropertyChanged
    {
        private int id { get; set; }
        private string name { get; set; }


        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public static ObservableCollection<Person> GetAll()
        {
            ObservableCollection<Person> ps = new ObservableCollection<Person>();
            ps.Add(new Person { Id = 1, Name ="Zaki" });
            ps.Add(new Person { Id = 2, Name="Faisal" });
            ps.Add(new Person { Id = 1, Name = "Another" });

            return ps;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
