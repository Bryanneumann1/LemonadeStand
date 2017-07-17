using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemons> lemons = new List<Lemons>();
        public List<Ice> icecubes = new List<Ice>();
        public List<Sugar> sugarcubes = new List<Sugar>();
        public Lemons lemon = new Lemons();
        public Ice ice = new Ice();
        public Sugar sugar = new Sugar();

        public void AddLemons(int LemonsNeeded)
        {
            for (int i = 0; i < LemonsNeeded; i++)
            {
                Lemons lemon = new Lemons();
                lemons.Add(lemon);

            }
            
        }
        public void AddSugar(int SugarNeeded)
        {
            for (int i = 0; i < SugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                sugarcubes.Add(sugar);

            }

        }
        public void AddIce(int IceNeeded)
        {
            for (int i = 0; i < IceNeeded; i++)
            {

                Ice ice = new Ice();
                icecubes.Add(ice);

            }

        }

    }
}
