﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Business
{
    public class DuplicateProductException : Exception
    {
        public DuplicateProductException(string message) : base(message)
        {

        }
    }
}
