using GuessNumber.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Models
{
    internal class RandomGen : IRandomGen
    {
        public int GetRandomNumbers(int _from, int _to)
        {
            Random random = new Random();
            
            var randomNumbers = random.Next(_from, _to);

            return randomNumbers ;
        }
    }
}
