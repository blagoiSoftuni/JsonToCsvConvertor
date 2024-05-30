using System.IO.IsolatedStorage;

namespace ThirdWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Printmatrix(a);
        }
        static void Printmatrix(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 1; j < a;j++)
                {
                    Console.Write(a + " ");
                }
                    Console.WriteLine(a); 
            }
        }
    }
}
