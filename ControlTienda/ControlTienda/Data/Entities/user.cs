﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
     public class user
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string direction { set; get; }
        public string telephone { set; get; }
        public string password { set; get; }
    }
}