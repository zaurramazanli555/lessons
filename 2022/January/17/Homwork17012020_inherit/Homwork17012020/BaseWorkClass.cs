using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork17012020
{
    class BaseWorkClass :Person
    {
        public DateTime DateOfStartWorking { get; set; }
        public DateTime DateOfEndWorking { get; set; }
        public int RestDays { get; set; }
    }
}
