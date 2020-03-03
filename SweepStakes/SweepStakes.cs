using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public  class SweepStakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        string sweepStakesName;
        string Name;       
        int registration;
        int winner;
        
        public SweepStakes()
        {


        }
        public void SweepStake(string name)
        {
            Console.WriteLine("Please choose a name for your Sweep Stakes? ");
            sweepStakesName = Console.ReadLine();
        }
        public void RegisterContestant(Contestant contestant)
        {
            int count;
            Console.WriteLine("Enter number of contestants");
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                registration = contestants.Count + 1;
                contestant.registration = registration;
                contestants.Add(registration, contestant);
            }


        }
        public void PickWinner() 
        {
            Random random = new Random();
            winner = random.Next(1, contestants.Count);
            Console.WriteLine(winner);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(winner);
        }
        

    }
}
