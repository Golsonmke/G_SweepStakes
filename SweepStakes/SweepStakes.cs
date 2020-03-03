using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        Dictionary<int, Contestant> contestants;
        int registration;
        int winner;
        
       
        public SweepStakes(string Name)
        {
            contestants = new Dictionary<int, Contestant>();
            Console.WriteLine("Please choose a name for your Sweep Stakes? ");
            Name =  Console.ReadLine();
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
        public Contestant PickWinner()
        {
            
            Random random = new Random();
            winner = random.Next(1, contestants.Count);
            Contestant contestant = contestants[winner];
            Console.WriteLine(winner);
            return contestant;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName, contestant.lastName);
            Console.WriteLine(contestant.email, contestant.registration);
        }
        

    }
}
