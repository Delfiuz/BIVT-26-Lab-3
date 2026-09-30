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
            int stud = 1;
            int lox = 0;
            bool flag = false;
            for (int i = 0; i < n * 4; i++)
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
                    stud += 1;
                    flag = true;
                }
            }
            if (count != 0) average = (double)(grad / count);
            Console.WriteLine(lox);
            Console.WriteLine(average);

            return (lox, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here

            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here

            // end

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