using System.ComponentModel;

namespace exDaiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoV = alf.ToCharArray();

            Console.WriteLine("Digite ate q letra voce ira querer formar o diamante:");
            char C = char.Parse(Console.ReadLine());

            int n = 0;
            for (int i = 0; i < alfabetoV.Length; i++)
            {
                if (alfabetoV[i] == C)
                {
                    n = i;
                }
            }

            int NumBrancos = n;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < NumBrancos; j++)
                {
                    Console.Write(" ");
                }
                NumBrancos--;
                for (int j = 0; j <= i * 2; j++)
                {
                    if (j == 0 || j == i * 2)
                    {
                        Console.Write(alfabetoV[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            NumBrancos = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = NumBrancos; j > 0; j--)
                {
                    Console.Write(" ");
                }
                NumBrancos++; ;
                for (int j = i * 2; j >= 0; j--)
                {
                    if (j == 0 || j == i * 2)
                    {
                        Console.Write(alfabetoV[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

