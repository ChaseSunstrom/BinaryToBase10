namespace BinaryToBase10
{
    class Program
    {
        public static void Main(string[] args)
        {
            double add = 0;
            Console.WriteLine("Enter a binary number: ");
            string num = Console.ReadLine();
    
            num.Reverse();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '1')
                {
                    add += Math.Pow(2, i);
                }
                
                else if (num[i] != '1' && num[i] != '0')
                {
                    Console.WriteLine("Enter a valid binary number.");
                    break;
                }
            }
            
            Console.WriteLine(add);
        }
    }
}