namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            double c = 0;
            // code here
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                double ves1 = double.Parse(s);

                if (ves1 < norma)
                {
                    c++;
                }
                milk = (c * glass) / 1000.0;
            }
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                string x1 = Console.ReadLine();
                string y1 = Console.ReadLine();
                double x = double.Parse(x1);
                double y = double.Parse(y1);
                if (x > 0 && y > 0)
                    first++;
                else if (y > 0 && x < 0)
                    second++;
                else if (y < 0 && x < 0)
                    third++;
                else if (x > 0 && y < 0)
                    fourth++;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for(int i = 0; i < n; i++)
            {
                string pr1 = Console.ReadLine();
                string pr2 = Console.ReadLine();
                string pr3 = Console.ReadLine();
                string pr4 = Console.ReadLine();
                int p1 = int.Parse(pr1);
                int p2 = int.Parse(pr2);
                int p3 = int.Parse(pr3);
                int p4 = int.Parse(pr4);
                if (p1 > 3 &&  p2 > 3 && p3 > 3 && p4 > 3)
                    count++;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime = 00;
            int Tasktime = 10;
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += Tasktime;
                    Tasktime += 5;
                    tasks--;
                }
                else
                {
                    seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            switch (number)
            {
                case 1:
                    {
                        power += 10;
                        intellect -= 5;
                        if (intellect < 0)
                            intellect = 0;
                        break;
                    }
                case 2:
                    {
                        agility += 5;
                        intellect -= 5;
                        power -= 5;
                        if (intellect < 0)
                            intellect = 0;
                        if (power < 0)
                            power = 0;
                        break;
                    }
                case 3:
                    {
                        power += 10;
                        intellect -= 5;
                        if (intellect < 0)
                            intellect = 0;
                        break;
                    }
                case 4:
                    {
                        agility += 15;
                        power -= 10;
                        intellect -= 10;
                        if (intellect < 0)
                            intellect = 0;
                        if (power < 0)
                            power = 0;
                        break;
                    }
                case 5:
                    {
                        intellect += 7;
                        power -= 5;
                        if (power < 0)
                            power = 0;
                        break;
                    }
                default:
                    power += 0;
                    intellect += 0;
                    agility += 0;
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }
}
