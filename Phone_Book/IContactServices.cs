﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book
{
    public interface IContactServices
    {
        public void Execute(Contact contact);
    }
}