﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemons> lemons = new List<Lemons>();
        public List<Ice> ice = new List<Ice>();
        public List<Sugar> sugar = new List<Sugar>();

        public void AddLemons(int LemonsNeeded)
        {
            for (int i = 0; i < LemonsNeeded; i++)
            {
                Lemons lemon = new Lemons();
                lemon.Add(lemons);
            }
        }

    }
}
