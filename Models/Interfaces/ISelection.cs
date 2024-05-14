using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Models.Interfaces
{
    internal interface ISelection
    {
        void Select(int index, int randomNumber);
    }
}
