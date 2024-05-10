using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Models.Interfaces
{
    internal interface IValidArgs
    {
        int[] ParamInp(string[] args);
    }
}
