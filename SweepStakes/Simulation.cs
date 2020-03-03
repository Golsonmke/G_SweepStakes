using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Simulation
    {
        public Simulation()
        {
            // My factory Class. 
        }
        public void CreateMarketingFirm()
        {
            int input;
            Console.WriteLine("Press 1 for Stack management type. ");
            Console.WriteLine("Press 2 for Queue management style. ");
            input = int.Parse(Console.ReadLine());
            ISweepStakesManager manager =null;
            if (input == 1)
            {
                manager = new SweepStakesStackManager();
            }
            else if (input == 2)
            {
                manager = new SweepStakesQueueManager();
            }
            else
            {
                Console.WriteLine("Please enter a valid input. ");
                CreateMarketingFirm();
            }
            MarketingFirm marketingFirm = new MarketingFirm(manager);
          

        }
    }
}
