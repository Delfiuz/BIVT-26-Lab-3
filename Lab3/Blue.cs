namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            for (int i = 0; i < n; i++)
            {
                string x1 = Console.ReadLine();
                int x = int.Parse(x1);
                if (norma - x > 0)
                {
                    milk += glass;
                }
            }
            milk /= 1000;
            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;
            for (int i = 0; i < n*2; i++)
            {
                string x1 = Console.ReadLine();
                string y1 = Console.ReadLine();
                int x = int.Parse(x1);
                int y = int.Parse(y1);
                if (x>0 && y>0){
                    first ++;                    
                }
                if (x<0 && y>0){
                    second ++;                    
                }
                if (x<0 && y<0){
                    third ++;
                }
                if (x>0 && y<0){
                    fourth ++;
                }
            }
            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string one1 = Console.ReadLine();
                string two1 = Console.ReadLine();
                string three1 = Console.ReadLine();
                string four1 = Console.ReadLine();
                int one = int.Parse(one1);
                int two = int.Parse(two1);
                int three = int.Parse(three1);
                int four = int.Parse(four1);
                if (one > 3 && two > 3 && three > 3 && four > 3)
                {
                    count ++;
                }
            }
            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int seriasTime = 10;
            int taskTime = 10;
            if (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks --;
                }
                else
                {
                    string x1 = Console.ReadLine();
                    seriasTime = int.Parse(x1);
                    time += seriasTime;
                    serias++;
                }
            }
            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            switch (number)
            {
                default:
                break;

                case 1:
                power += 10;
                agility += 0;
                intellect -= 5;
                break;

                case 2:
                power -= 5;
                agility += 5;
                intellect -= 5;
                break;

                case 3:
                power += 10;
                agility += 0;
                intellect -= 5;
                break;

                case 4:
                power -= 10;
                agility += 15;
                intellect -= 10;
                break;

                case 5:
                power -= 5;
                agility += 0;
                intellect += 7;
                break;
            }
            return (power, agility, intellect);
        }
    }
}
