using GuessNumber.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Controller
    {        
        public IValidArgs validArgs { get; set; }
        public IRandomGen randomGen { get; set; }
        public Controller(IValidArgs _validArgs, IRandomGen _randomGen)
        {
            this.validArgs = _validArgs;
            this.randomGen = _randomGen;
        }
        public void RunController(string[] args)
        {
            int[] param = new int[3];

            param = validArgs.ParamInp(args);

            var randomNumber = randomGen.GetRandomNumbers(param[1], param[2]);


            Console.WriteLine(randomNumber);




        }
    }
}
