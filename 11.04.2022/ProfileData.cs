using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04._2022
{
    internal class ProfileData(string Name, int Money)
    {
        protected string Name { get; set; } = Name;
        protected int Money { get; set; } = Money;
    }
}
