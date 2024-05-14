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
        public ISelection selection { get; set; }
        public Controller(IValidArgs _validArgs, IRandomGen _randomGen, ISelection _selection)
        {
            this.validArgs = _validArgs;
            this.randomGen = _randomGen;
            this.selection = _selection;
        }
        public void RunController(string[] args)
        {
            int[] param = new int[3];

            param = validArgs.ParamInp(args);

            var randomNumber = randomGen.GetRandomNumbers(param[1], param[2]);

            selection.Select(param[0], randomNumber);        

        }
    }
}
