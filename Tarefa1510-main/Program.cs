using System;

namespace Aula2210
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n1;
            int n2;

            
            centralizarMensagem("Este programa fará a soma de 2 valores", 1);

           
            n1 = EntraInt("Atribua um valor para n1:", 4, 30, 5, 10);
            n2 = EntraInt("Atribua um valor para n2:", 6, 30, 10, 20);

            mostraMensagem("Saída: ", 8, 25);
            
            Console.WriteLine("O resultado da operação de adição entre {0} e {1} é {2}", n1, n2, Calcular(n1, n2));

            
            centralizarMensagem("Encerrando o programa...", 10);
            
            emoldurarMensagem("Programa Finalizado", 16);

            Console.WriteLine();
        }
        static int EntraInt(string msg, int linha, int coluna, int li, int ls)
        {
            
            int x;
            
            do
            {
                mostraMensagem(msg, linha, coluna);
                x = int.Parse(Console.ReadLine());
            }
            while (x < li || x > ls);
            
            return x;
        }
        static int Calcular(int x, int y)
        {
            
            return (x + y);
        }
        static void centralizarMensagem(string msg, int linha) 
        {
            int coluna;
            coluna = ((120 - msg.Length) / 2) + 1;
            
            mostraMensagem(msg, linha, coluna);

        }
        static void mostraMensagem(string msg, int linha, int coluna) 
        {
           
            Console.SetCursorPosition(coluna, linha);
           
            Console.Write(msg);
        }
        static void emoldurarMensagem(string msg, int linha) 
        {
           
            int coluna;
            string aresta;

            coluna = ((120 - (msg.Length+4)) / 2) + 1;
            aresta = "+";
            for (int i = 1; i <= msg.Length + 2; ++i)
                aresta += "-";
            aresta += "+";
          
            mostraMensagem(aresta, linha - 1, coluna);
            mostraMensagem("| " + msg + " |", linha, coluna);
            mostraMensagem(aresta, linha + 1, coluna);
            }
        }
}

