using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFilteringOpg
{
    internal class NameFilter : PersonFilter
    {
        internal string? name;
        public NameFilter(string? name)
        {
            this.name = name;
        }

        internal override bool FilterPredicate(Person person)
        {
            return person.name == name;
        }
    }
}
