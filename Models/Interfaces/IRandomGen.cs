using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Models.Interfaces
{
    internal interface IRandomGen
    {
        int GetRandomNumbers(int _from, int _to);
    }
}
