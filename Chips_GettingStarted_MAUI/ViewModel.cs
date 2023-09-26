using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chips_GettingStarted_MAUI
{
    public class ViewModel
    {
        public List<Person> Employees { get; set; }

        public ViewModel()
        {
			Employees = new List<Person>()
			{
				new Person() { Name = "John" },
				new Person() { Name = "James" },
				new Person() { Name = "Linda" },
				new Person() { Name = "Rose" },
				new Person() { Name = "Mark" }
			};

		}
    }
}
