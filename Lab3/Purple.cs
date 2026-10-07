using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
            double x = 0;
            double y = 0;
            for (int i = 0; i < n; i++)
            {
                x = Double.Parse(Console.ReadLine());
                y = Double.Parse(Console.ReadLine());
                if ((x * x) + (y * y) <= r1 * r1)
                {
                    count++;
                    if ((x * x) + (y * y) <= r2 * r2)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            for (int i=0; i<n; i++)
            {
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());
                int a3 = int.Parse(Console.ReadLine());
                int a4 = int.Parse(Console.ReadLine());
                average += (a1 + a2 + a3 + a4) / 4.0;
                if (a1 == 2 || a2 == 2 || a3 == 2 || a4 == 2)
                {
                    count++;
            
                }
            }

            average /= n;
            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int theory, practice, mark, n = exams;
            double score = 0;
            while (exams > 0)
            {
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score>85)
                {
                    mark = 5;
                }
                else if (score > 70)
                {
                    mark = 4;
                }
                else if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }

                avgMark += mark/n;
                exams--;
            }
            
            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            code = int.Parse(Console.ReadLine());
            limit = int.Parse(Console.ReadLine());
            int attempts = 0;
            for (;limit>0; limit--)
            {
                string a = Console.ReadLine();
                attempts++;
                int codep = int.Parse(a);
                bool b = a.Contains("-");
                if (b == true)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                else if (codep == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
                
            }

            solution = "Система заблокирована!";
            
            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            int a1 = a;
            for (; a < a1+ n; a++)
            {
                int c = 0;
                if (a == 1 || a == 8 || a == 15 || a == 22 || a == 29)
                {
                    c++;
                }
                if (a == 4 || a == 11 || a == 18 || a == 25 )
                {
                    c+=2;
                }
                if (a == 7 || a == 14 || a == 21 || a == 28)
                {
                    c+=3;
                }
                switch (c)
                {
                    case 1:
                        if (luck < 67)
                        {
                            luck *= 1.5;
                        }
                        else
                        {
                            luck = 100;
                        }
                        break;
                    case 2:
                        if (luck >= 10)
                        {
                            luck -= 10;
                        }
                        else
                        {
                            luck = 0;
                        }
                        break;
                    case 3:
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;
                    default:
                        if (luck <= 95)
                        {
                            luck += 5;
                        }
                        else
                        {
                            luck = 100;
                        }
                        break;
                }
                
            }

            return luck;
        }
    }
}
