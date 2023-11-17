namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kara jadval
            Console.Write("Nechi karagacha:");
            int n = int.Parse(Console.ReadLine());
            // for while
            for(int i = 1; i <= 10; i++)
            {
                for(int j =1; j <=n; j++)  //1x1=1  2x1=2  3x1=3
                                           // 1x2=2  2x2=4  3x2=6
                {
                    Console.Write($"{j} x {i} = {i * j}\t");
                }
                Console.WriteLine(" ");

            }
            
        }
    }
}