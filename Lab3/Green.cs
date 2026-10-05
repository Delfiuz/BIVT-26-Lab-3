namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for(int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
                {
                    count += 1;
                }    

            }
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;


            // code here
            for (int i = 0; i < n; i++)

            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double currentLength = Math.Sqrt(x * x + y * y);

                if (i == 0)
                {
                    length = currentLength;
                    index = 1;
                }
                else if (currentLength < length)
                {
                    length = currentLength;
                    index = i + 1;
                }

            }    

            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                string inputX = Console.ReadLine();

                if (!double.TryParse(inputX, out double x))
                {
                    break;
                }
                string inputY = Console.ReadLine();
                if (!double.TryParse(inputY, out double y))
                {
                    break;
                }
                if (x >= 0 && x <= Math.PI && y >=0 && y <= Math.Sin(x))
                {
                    count++;
                }

            }

            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while (labs > 0 || cw > 0)
            {
                int mark = int.Parse(Console.ReadLine());
                if (labs > 0)
                {
                    score += mark;
                    labs -= 1;


                }
                else
                {
                    score += 4 * mark;
                    cw -= 1;
                }
            }

            // end

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here
            switch(type)
            {
                case 1:
                    area = a * b;
                    break;
                case 2:
                    area = Math.PI * Math.Abs(a * a - b * b);
                    break;
                case 3:
                    double h = Math.Sqrt(b * b - (a / 2.0) * (a / 2.0));
                    area = (h * a) / 2;
                    break;
            }

            // end

            return area;
        }
    }
}
