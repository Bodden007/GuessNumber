using GuessNumber.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GuessNumberTest")]

namespace GuessNumber.Models
{
    internal class ValidArgs : IValidArgs
    {
        public int[] ParamInp(string[]? args)
        {
            int[] param = new int[3];
            bool validParam = false;

            if (args.Length >= 3)
            {
                try
                {
                    param[0] = Convert.ToInt32(args[0]);
                    param[1] = Convert.ToInt32(args[1]);
                    param[2] = Convert.ToInt32(args[2]);

                    if ((param[0] < 1) || (param[2] <= param[1]))
                    {
                        Console.WriteLine("С такими параметрами не чего угадывать, вводи в ручную: ");
                        Array.Clear(args, 0, args.Length);
                    }
                    else { validParam = true; }
                }
                catch (Exception)
                {
                    Console.WriteLine("Параметры аргументов не верны, попробуй ввести в ручную");
                    Array.Clear(args, 0, args.Length);
                }
            }

            while (!validParam)
            {
                if (args.Length == 0 || args.Length < 3 || args[0] == null)
                {
                    try
                    {
                        Console.WriteLine("Введите кол. попыток");
                        param[0] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите диапозон чисел");
                        Console.WriteLine("от: ");
                        param[1] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("до: ");
                        param[2] = Convert.ToInt32(Console.ReadLine());

                        if ((param[0] < 1) || (param[2] <= param[1]))
                        {
                            Console.WriteLine("С такими параметрами не чего угадывать, пробуй еще раз: ");
                        }
                        else { validParam = true; }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ошибка ввода параметров, попробуй еще раз");
                    }
                }

            }
            return param;
        }

    }
}
