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

            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

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
                bool flag = false;

                for (int j = 1; j < 5; j++)
                {
                    int oc = int.Parse(Console.ReadLine());
                    countoc = countoc + oc;

                    if (oc == 2)
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    count2++;
                }
        
            }

            double srgroup = (double)countoc / (n * 4);
            Console.WriteLine(srgroup);

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
            string solution = "Код не подобран";
            int attempts = 0;
            bool flag = true;
            string status = "Аварийный выход";
            string failed = "Система заблокирована";

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here

            // end

            return luck;
        }
    }
}