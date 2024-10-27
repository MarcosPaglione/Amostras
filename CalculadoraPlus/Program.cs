using System;

namespace CalculadoraPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marcos Eliezer Paglione \n");
            String operador, linha2;
            Double n1, n2, resultado;
            Console.Title = ("Calculadora Plus");

            Console.Write("Digite o Primeiro: ");
            n1 = Convert.ToDouble(Console.ReadLine().Replace(".", ",")); //Replace troca , por .

            Console.Write("Digite operador: ");
            operador = Console.ReadLine();


            linha2 = ("Digite o Segundo: ");
            if (operador == "%")
            {
                linha2 = ("Digite a porcentagem: ");
            }
            Console.Write(linha2);
            n2 = Convert.ToDouble(Console.ReadLine().Replace(".", ",")); //Replace troca "," por "."

            if (operador == "+")
            {
                resultado = n1 + n2;
                Console.WriteLine("\n Soma: " + resultado);
            }
            else if (operador == "-")
            {
                resultado = (n1 - n2);
                Console.WriteLine("\n Subtração: " + resultado);
            }
            else if (operador == "*" || operador == "X")
            {
                resultado = (n1 * n2);
                Console.WriteLine("\n Multiplicação: " + resultado);
            }
            else if (operador == "/" || operador == "÷")
            {
                resultado = (n1 / n2);
                Console.WriteLine("\n Divisão: " + resultado);
            }
            else if (operador == "%")
            {
                Console.WriteLine("\n Voce deseja: \n (-)Desconto ou (+)Acréscimo:");
                operador = Console.ReadLine();
                if (operador == "-")
                {
                    // valor*O%/100
                    resultado = (n1 * n2 / 100);
                    Console.WriteLine("\n" + n2 + "% de " + n1 + " é " + resultado);
                    // Desconto 15% = Valor-Valorx15/100
                    resultado = (n1 - n1 * n2 / 100);
                    Console.WriteLine("\n" + n1 + " menos " + n2 + "% de Desconto = " + resultado);
                }
                else if (operador == "+")
                {
                    // valor*O%/100
                    resultado = (n1 * n2 / 100);
                    Console.WriteLine("\n" + n2 + "% de " + n1 + " = " + resultado);
                    // Acréscimo 15% = Valor+Valorx15/100
                    resultado = (n1 + n1 * n2 / 100);
                    Console.WriteLine("\n" + n1 + " mais " + n2 + "% de Acréscimo = " + resultado);
                }
                else
                {
                    Console.WriteLine("\n ERRO! (" + operador + ") não é válido! \n aceitos: - ou +");
                }
            }
            else
            {
                Console.WriteLine("\n ERRO! Operador (" + operador + ") não é válido!");
            }
            Console.ReadKey();
        }
    }
}
