namespace CalculateSquareRoot
{
    public class program
    {
        static void Main(string[] args)
        {
            int num, sq = 1;
            Console.Write("enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());

            test(num);

            Console.Write("the squareroot of number is : ");
            Console.WriteLine(test(num));

        }

        public static int test(double number)
            {
                int sq = 1;
                //int num;
                while (sq < number / sq)
                {
                    sq++;
                }
                if (sq > number / sq) return sq - 1;
                return sq;

                //Console.ReadLine();
            }

        
    }
}
