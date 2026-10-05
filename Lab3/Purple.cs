using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double d = Math.Sqrt((x * x) + (y * y));

            if (d >= r1 && d <= r2)
            {
                count++;
            }
            

            return count;
            
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            int count2 = 0;
            int countoc = 0;

            for (int i = 0; i < n; i++)
            {
                int mark1 = int.Parse(Console.ReadLine());
                int mark2 = int.Parse(Console.ReadLine());
                int mark3 = int.Parse(Console.ReadLine());
                int mark4 = int.Parse(Console.ReadLine());

                countoc += mark1 + mark2 + mark3 + mark4;

                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                {
                    count++;
                }
            }
            
            average = (double)countoc / (n * 4);
            Console.WriteLine(average);
            
            return (count, average);
        }
        public double Task3(int exams)
        {

            int theory, practice, mark, n = exams;
            double score, avgmark = 0;

            while (exams > 0)
            {
                Console.Write("баллы за теорию:");
                theory = int.Parse(Console.ReadLine());
                Console.Write("баллы за практику:");
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                    mark = 5;
                else if (score > 70)
                    mark = 4;
                else if (score > 50)
                    mark = 3;
                else
                    mark = 2;
                avgmark += (double)mark / n;
                exams--;

            }

            return avgmark;
            
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            int attempts = 0;
            string status = "Аварийный выход!";
            bool flag = false;


            while (attempts < limit)
            {
                attempts++;
                int code1 = int.Parse(Console.ReadLine());
                int code2 = int.Parse(Console.ReadLine());
                int code3 = int.Parse(Console.ReadLine());

                if (code1 == -1 || code2 == -1 || code3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                string attemptSTR = code1.ToString() + code2.ToString() + code3.ToString();
                int attemptINT = int.Parse(attemptSTR);

                if (attemptINT == code)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                solution = "Доступ разрешен!";
            }

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            

            for (int day = a; day < a + n; day++)
            {
                switch (day)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck *= 1.5;
                        if (luck > 100)
                            luck = 100;
                        break;
                    
                    case 4 or 11 or 18 or 25:
                        luck -= 10;
                        if (luck < 0)
                            luck = 0;
                        break;
                    
                    case 7 or 14 or 21 or 28:
                        if (luck < 50)
                            luck = 55;
                        break;
                    
                    default:
                        luck += 5;
                        if (luck > 100)
                            luck = 100;
                        break;
                }
            }
            

            return luck;
        }
    }
}