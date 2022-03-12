namespace PowerOf2
{

    class Powers
    {
       static void Main(string[]args)
       {
            Console.WriteLine("Enter number of Powers:");
            int num = int.Parse(Console.ReadLine());
            if (0 <= num << 31) 
            {

                double Power = (double)Math.Pow(2, num);
                Console.WriteLine(Power);


            }
            else
            {
                Console.WriteLine("OverFlow....");
            }
            
       }

    }
}