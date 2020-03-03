using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class UserInterface
    {
        public UserInterface()
        {

        }
        public void CreateContestant(Contestant contestant)
        {
            Console.WriteLine("What is Your first name?  ");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("What is your email? ");
            contestant.email = Console.ReadLine();

        }
    }
}
