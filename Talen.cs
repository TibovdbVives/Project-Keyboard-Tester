﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Keyboard_Tester
{
    internal class Talen
    {
        public virtual string HeaderMessage()
        {
            return "Keyboard Test Program";
        }
        
        public virtual string ChooseMessage()
        {
            return "Choose Keyboard Type";
        }
    }
}