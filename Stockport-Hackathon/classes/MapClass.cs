﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing.Maps;
namespace Stockport_Hackathon.classes
{
    class MapClass
    {
        private Map m = new Map();


        public MapClass()
        {

        }

        public void loadAtStockport()
        {
            m.Center = new Location(53.41, -2.16);
        }
    }
}
