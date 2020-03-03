using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm 
    {
        // I am using dependancy injection here. We use this in case we would want to expand on the ISweepStakesManager Class.
        ISweepStakesManager manager;
        string Name;
        public MarketingFirm(ISweepStakesManager manager)
        {
            this.manager = manager;
        }
        public void CreateSweepStakes() 
        {
          SweepStakes sweepStakes = new SweepStakes(Name);
            manager.InsertSweepStakes(sweepStakes);
        }
    }
    

}
