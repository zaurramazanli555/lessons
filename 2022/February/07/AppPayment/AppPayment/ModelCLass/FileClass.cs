﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPayment.ModelCLass
{
    internal class FileClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public DocumentPayment DocumentPayment { get; set; }
    }
}
