using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Xml;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            { 

                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if ((r1*r1 <= x*x + y*y) && (x * x + y * y <= r2*r2))
                {
                    count++;
                }

            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            int s = 0;
            // code here
            for (int i = 0; i < n; i++)
            {
                int x1 = int.Parse(Console.ReadLine());
                int x2 = int.Parse(Console.ReadLine());
                int x3 = int.Parse(Console.ReadLine());
                int x4 = int.Parse(Console.ReadLine());
                if (x1 == 2 || x2 == 2 || x3 == 2 || x4 == 2)
                { count++; }
                s = s + x1 + x2 + x3 + x4;

            }
            average = (double)s / (n*4);
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int theory, practice, mark, n = exams;
            // code here
            while (exams < 0)
            {
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                double score = (double)theory * 0.4 + (double)practice * 0.6;
                switch (score)
                {
                    case > 85:
                        mark = 5;
                        break;
                    case > 70:
                        mark = 4;
                        break;
                    case > 50:
                        mark = 3;
                        break;
                    default:
                        mark = 2;
                        break;  
                }
                avgMark += (double)mark / n;
                exams--;    

            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            int xc1 = code / 100;
            int xc2 = code / 10 % 10;
            int xc3 = code % 10;
            // code here
            for (; limit > 0; limit--)
            {
                attempts++;
                int x1 = int.Parse(Console.ReadLine()!);
                if (x1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                int x2 = int.Parse(Console.ReadLine()!);
                if (x2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                int x3 = int.Parse(Console.ReadLine()!);
                if (x3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if (x1 == xc1 && x2 == xc2 && x3 ==  xc3)
                {
                    solution = "Доступ разрешен!";
                    break;  
                }
            }
            if (solution == "Код не подобран")
            {
                solution = "Система заблокирована!";
            }
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for(int i = 0;i<n;i++)
            {
                int day = a + i;
                switch (day)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck = Math.Min(luck * 1.5, 100);   
                        break;
                    case 4 or 11 or 18 or 25:
                        luck = Math.Max(luck - 10, 0);
                        break;
                    case 7 or 14 or 21 or 28:
                        if (luck < 50)
                        { luck = 55; };
                        break;
                    default:
                        luck = Math.Min(luck + 5, 100);
                        break;

                }
            }
            // end

            return luck;
        }
    }
}