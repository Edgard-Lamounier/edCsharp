using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRecursion01
{
    internal class Program
    {
        public int fatorial(int n)
        {
            if (n == 0 || n  == 1) return 1;

            else return (n * fatorial(n - 1));
        }

        public void torresHanoi(int n, char prAste, char ultAste, char auxAste)
        {
            // Condição de parada: um disco só
            if(n == 1)
            {
                Console.WriteLine("Mova disco 1 da aste " + prAste + " para a aste " + ultAste);
                return;
            }

            // Mova n - 1 discos da aste A para B, usando C como auxiliar
            torresHanoi(n - 1, prAste, auxAste, ultAste);

            // Mova discos remanescentes de A para C
            Console.WriteLine("Mova disco " + n + " da aste " + prAste + " para a aste " + ultAste);

            // Mova n - 1 discos da aste B para C, usando A como auxiliar
            torresHanoi(n - 1, auxAste, ultAste, prAste);
        }

        // Recorrencia de S(n) iterativo
        // 1. S(1) = 2
        // 2. S(n) = 2S(n - 1)
        public int S_Iterativo(int n)
        {
            int i;
            int valorCorrente;

            if (n == 1) { return 2; }
            else
            {
                i = 2;
                valorCorrente = 2;

                while(i <= n) 
                {
                    valorCorrente = 2 * valorCorrente;
                    i++;
                }
                return valorCorrente;
            }
        }

        public int S_Recursivo(int n)
        {
            if (n == 1) { return 2; }
            
            else
                return (2 * S_Recursivo(n - 1));        
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            //Console.WriteLine("O fatorial de 5 é: " + program.fatorial(5));
            //Console.ReadLine();

            //Console.WriteLine("****** TORRES DE HANOI *******");
            //program.torresHanoi(4, 'A', 'C', 'B');
            //Console.ReadLine();

            Console.WriteLine("****** S ITERATIVO *******");
            Console.WriteLine("O elemento 5 de S Iterativo é: " + program.S_Iterativo(5)); 
            Console.ReadLine();

            Console.WriteLine("****** S RECURSIVO *******");
            Console.WriteLine("O elemento 5 de S Recursivo é: " + program.S_Recursivo(5));
            Console.ReadLine();
        }
    }
}
