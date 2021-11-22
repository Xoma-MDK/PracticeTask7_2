using System;

namespace PracticeTask7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte valAnswers;
            valAnswers = Convert.ToByte(Console.ReadLine());
            switch (valAnswers)
            {
                case 0: Console.WriteLine("За 0 правильных ответов, Вы получаете 0 рублей"); break;
                case 1: Console.WriteLine("За 1 правильных ответов, Вы получаете 100 рублей"); break;
                case 2: Console.WriteLine("За 2 правильных ответов, Вы получаете 200 рублей"); break;
                case 3: Console.WriteLine("За 3 правильных ответов, Вы получаете 300 рублей"); break;
                case 4: Console.WriteLine("За 4 правильных ответов, Вы получаете 500 рублей"); break;
                case 5: Console.WriteLine("За 5 правильных ответов, Вы получаете 1000 рублей"); break;
                case 6: Console.WriteLine("За 6 правильных ответов, Вы получаете 2000 рублей"); break;
                case 7: Console.WriteLine("За 7 правильных ответов, Вы получаете 4000 рублей"); break;
                case 8: Console.WriteLine("За 8 правильных ответов, Вы получаете 8000 рублей"); break;
                case 9: Console.WriteLine("За 9 правильных ответов, Вы получаете 16000 рублей"); break;
                case 10: Console.WriteLine("За 10 правильных ответов, Вы получаете 32000 рублей"); break;
                case 11: Console.WriteLine("За 11 правильных ответов, Вы получаете 64000 рублей"); break;
                case 12: Console.WriteLine("За 12 правильных ответов, Вы получаете 125000 рублей"); break;
                case 13: Console.WriteLine("За 13 правильных ответов, Вы получаете 250000 рублей"); break;
                case 14: Console.WriteLine("За 14 правильных ответов, Вы получаете 500000 рублей"); break;
                case 15: Console.WriteLine("За 15 правильных ответов, Вы получаете 1000000 рублей"); break;
                default: Console.WriteLine("Ошибка ввода"); break;
            } 
        }
    }
}
