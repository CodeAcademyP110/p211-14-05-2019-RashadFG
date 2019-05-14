using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._05._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //first task start

            //Console.WriteLine("please input first sentences");
            //string Sentences = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < Sentences.Length; i++)
            //{
            //    //frist way
            //    string number = Sentences.Substring(i, 1);
            //    //second way    
            //    //string number = Sentences[i].ToString();

            //    if (number == " ")
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            ////third way
            //Console.WriteLine("please  input  second sentences");
            //string Sentences2 = Console.ReadLine();
            //int count2 = 0;
            //for (int i = 0; i < Sentences2.Length; i++)
            //{

            //    if (Sentences2[i] == ' ')
            //    {
            //        count2++;
            //    }
            //}
            //Console.WriteLine(count2);

            //first task start

            //second task start
            //int[] array1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            //int middle;
            //int sum=0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    sum += array1[i];
            //    middle = sum / array1.Length;
            //}
            //Console.WriteLine(middle);
            //second task end

            //third task start
            //int[] array2 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    if (array2[i] % 2 == 0)
            //    {
            //        Console.WriteLine(array2[i]);
            //    }
            //}
            //third task end


            //fourth task start
            //int[] array1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            //int middle = 0;
            //int sum = 0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    sum += array1[i];
            //    middle = sum / array1.Length;
            //}

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] > middle)
            //    {
            //        Console.WriteLine(array1[i]);
            //    }
            //}
            //fourth task end


            //fifth task start
            //int MainNumber = int.Parse(Console.ReadLine());
            //int upNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(UP(MainNumber, upNumber));
            //fifth task end

            //sixth task start
            //string[] WordsArray = new string[6] {"kamal", "bextiyar", "elcin","ilkin", "perviz" ,"Ulvi"};
            //int max=0;
            //string LongWord="";
            //for (int i = 0; i < WordsArray.Length; i++)
            //{
            //    if (WordsArray[i].Length > max)
            //    {
            //        max = WordsArray[i].Length;
            //        LongWord = WordsArray[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(LongWord);
            //sixth task end

            //seventh task start
            //string[] WordsArray = new string[6] {"kamal", "bextiyar", "elcin","ilkin", "perviz" ,"Ulvi"};
            //string result="";
            //for (int i = 0; i < WordsArray.Length; i++)
            //{
            //    if (i == WordsArray.Length-1)
            //    {
            //        result += WordsArray[i];
            //    }
            //    else
            //    {
            //        result += WordsArray[i] + ",";
            //    }
            //}
            //Console.WriteLine(result);
            //seventh task end

        }

        //static for sixth task start
        /// <summary>
        /// up function for tasks 6
        /// </summary>
        /// <param name="MainNumber">this number is first like down number</param>
        /// <param name="upNumber">this number is up of MainNumber </param>
        /// <returns></returns>
        static int UP(int MainNumber, int upNumber)
        {
            int result = 1;
            for (int i = 0; i < upNumber; i++)
            {
                result *= MainNumber;
            }
            return result;
        }
        //static for sixth task end

    }
}
