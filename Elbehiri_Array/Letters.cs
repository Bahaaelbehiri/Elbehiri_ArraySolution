using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elbehiri_Array
{
    class Charcters
    {
        public Char[] Array = new Char[50];
        char CurrentLetter;
        bool isFound = false;
        int CurrentIndex = 0;

        public void SetDataToArry(Char data, int index)
        {
            Array[index] = data;
        }

        public void GetFinalArray(string Characters)
        {
            var random = new Random();

            for (int i = 0; i < Characters.Length; i++)
            {
                isFound = false;
                CurrentLetter = Characters[random.Next(Characters.Length)];
                for (int j = 0; j < 50; j++)
                {
                    if (Array[j] == CurrentLetter)
                    {
                        isFound = true;
                        break;
                    }
                }
                if (isFound == false)
                {
                    if (CurrentIndex == 50) break;
                    SetDataToArry(CurrentLetter, CurrentIndex);
                    CurrentIndex++;
                }
            }
        }

        public void DisplayDataFromArry()
        {
            var resultString = new String(Array);
            Console.WriteLine(resultString);
        }
    }
}
