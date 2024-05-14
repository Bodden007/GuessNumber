using GuessNumber.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Models
{
    internal class Selection : ISelection
    {
        public void Select(int index, int randomNumber)
        {
            var flagSelect = false;

            for (int i = 1; i < index + 1; i++)
            {
                Console.WriteLine($"Попытка {i}, Введи число: ");
                var numberUser = Convert.ToInt32(Console.ReadLine());

                if (numberUser == randomNumber)
                {
                    flagSelect = true;
                    break;
                }
                else if (numberUser < randomNumber)
                {
                    Console.WriteLine("Твое число меньше загаданово");
                }
                else if (numberUser > randomNumber)
                {
                    Console.WriteLine("Твое число больше загаданово");
                }
            }

            if (flagSelect)
            {
                Console.WriteLine("Ты угадал число");
            }
            else
            {
                Console.WriteLine("Эх, ты не угадал число. Повезет в другой раз");
            }
        }
    }
}
