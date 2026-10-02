using System.Diagnostics;
using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
            
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine()!);
                double y = double.Parse(Console.ReadLine()!);
                double dot = Math.Sqrt(x * x + y * y);
                if (r1 < dot && r2 > dot)
                {
                    count++;
                }
            }

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            int grad = 0;
            double average = 0;
            int lox = 0;
            bool flag = true;
            for (int i = 1; i <= n * 4; i++)
            {
                int g = int.Parse(Console.ReadLine()!);
                count++;
                grad += g;
                if (g == 2 && flag)
                {
                    lox++;
                    flag = false;
                }
                if (i % 4 == 0 && i != 0)
                {
                    flag = true;
                }
            }
            if (count != 0) average = (double)grad / count;
            Console.WriteLine(lox);
            Console.WriteLine(average);

            return (lox, average);
        }
        public double Task3(int exams)
        {
            int theory;
            double avgMark = 0;
            int practice;
            int mark;
            double score;
            int n = exams;

            while (exams != 0)
            {
                theory = int.Parse(Console.ReadLine()!);
                practice = int.Parse(Console.ReadLine()!);
                score = 0.4 * theory + 0.6 * practice;
                mark = score switch
                {
                    > 85 => 5,
                    > 70 => 4,
                    > 50 => 3,
                    _ => 2,
                };
                avgMark += (double)mark / n;
                exams--;
            }
            
            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            string[] corrcode = code.ToString().Select(c => c.ToString()).ToArray();
            int attempts = 0;
            while (attempts < limit)
            {
                attempts++;
                string[] currcode = { Console.ReadLine()!, Console.ReadLine()!, Console.ReadLine()! };
                if (currcode.Contains("-1"))
                {
                    solution = "Аварийный выход!";
                    return (solution, attempts);
                }
                if (currcode.SequenceEqual(corrcode))
                {
                    solution = "Доступ разрешен!";
                    return (solution, attempts);
                }
            }
            
            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            for (int i = a; i < a + n; i++)
            {
                switch (i)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        if (1.5 * luck >= 100) luck = 100;
                        else luck *= 1.5;
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        if (luck <= 10) luck = 0;
                        else luck -= 10;
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        if (luck + 5 > 100) luck = 100;
                        else luck += 5;
                        break;
                }
            }

            return luck;
        }
    }
    
}