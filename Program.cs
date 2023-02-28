/*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
A seguir, calcule e mostre o valor da conta a pagar.
Codigo          Especificação             Peço
1               cachorro quente           R$4.00
2               x-salada                  R$4.50
3               x-bacon                   R$5.00
4               torrada simples           R$2.00
5               refrigerante              R$1.50

Entrada: 3 e 2 Saida: Total: R$10,00
         2 e 3        Total: R$13,50*/

using System.Globalization;

namespace Exercicio_if_else_05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do item: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade que você quer: ");
            int quantidade = int.Parse(Console.ReadLine());

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.0;

            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;

            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;

            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("Total é: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}