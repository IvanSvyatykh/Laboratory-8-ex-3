using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_8_ex_3
{
    internal class Program
    {
        static void Main()
        {
            int[] alphabetForFirstWord = new int[26];
            int[] alphabetForSecondWord = new int[26];
            List<string> resultOfArrray = new List<string>();
            string[] array = {  "framer", "frame" ,"code", "doce", "ecod" };
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array[i].Length; j++)
                {
                    // Увеличиваем элементы массива, номер которых является <=> UTF-8
                    string str = array[i].ToUpper();
                    alphabetForFirstWord[(int)str[j] - 65]++;

                }            
                if (!alphabetForFirstWord.SequenceEqual(alphabetForSecondWord))
                {
                    //Проверяем встреченное слово другое или нет
                    alphabetForFirstWord.CopyTo(alphabetForSecondWord, 0);
                    resultOfArrray.Add(array[i]);                   
                }
                Array.Clear(alphabetForFirstWord, 0, alphabetForFirstWord.Length);
            }
            resultOfArrray.Sort();
            foreach (string str in resultOfArrray)
                Console.WriteLine(str);
        }
    }
}
