using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomMinNumber = 1;
            int randomMaxNumber = 100;
            int degree = 1;
            int baseOfDegree = 2;
            int finalNumber = 1;
            Random random = new Random();
            int number = random.Next(randomMinNumber, randomMaxNumber);

            Console.WriteLine("Случайное число - " + number);

            for (int i = baseOfDegree; i <= number; i*=baseOfDegree)
            {
                degree++;
            }
            Console.WriteLine("Нужная степень двойки - " + degree);

            if (finalNumber < number)
            {
                finalNumber =Convert.ToInt32(finalNumber * baseOfDegree);
            }
            if (finalNumber<number)
            {
                finalNumber = Convert.ToInt32(finalNumber * baseOfDegree);
            }
            if (finalNumber<number)
            {
                finalNumber = Convert.ToInt32(finalNumber * baseOfDegree);
            }
            if (finalNumber<number)
            {
                finalNumber = Convert.ToInt32(finalNumber * baseOfDegree);
            }
            if (finalNumber<number)
            {
                finalNumber = Convert.ToInt32(finalNumber * baseOfDegree);
            }
            if (finalNumber<number)
            {
                finalNumber = Convert.ToInt32(finalNumber * baseOfDegree);
            }
            if(finalNumber<number)
            {
                finalNumber = Convert.ToInt32(finalNumber * baseOfDegree);
            }

            Console.WriteLine("число два в найденной степени - " + finalNumber);
        }
    }
}
