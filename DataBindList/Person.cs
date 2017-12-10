using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindList
{
    public class Person
    {
        public string Name { get; set; }



        public static ObservableCollection<Person> GetPersons()
        {
            var all = new ObservableCollection<Person>();
            all.Add(new Person { Name = "Zaki"});
            all.Add(new Person { Name = "Faisal" });
            all.Add(new Person { Name = "Next" });
            return all;
        }

    }
}
