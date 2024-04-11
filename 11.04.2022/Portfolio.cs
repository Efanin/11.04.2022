using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04._2022
{
    internal class Portfolio
    {
        public Dictionary<string, int> Stocks { get; set; } = new()
        {
            {"Apple", 0},
            {"Microsoft", 0},
            {"Google", 0},
            {"Tesla", 0},
            {"Amazon", 0},
        };
    }
}
