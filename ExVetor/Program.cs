using System;
using System.Globalization;

namespace ExVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Criando a variável de entrada
            Produto[] vect = new Produto[n]; //Criando vetor com o número da variável de entrada
            for(int i = 0; i < n; i++) //Utilização do comando for para percorrer o vetor
            {
                Console.Write("Nome do Produto: "); //Entrada do Nome do Produto
                string name = Console.ReadLine();
                Console.Write("Preço do Produto: R$"); //Entrada do Preço do Produto
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price };
            }
            double soma = 0.0; //Variável soma    
            for(int i= 0; i < n; i++) //Utilização do for para percorrer o vetor
            {
                soma += vect[i].Price; //Somatoriados elementos inseridos
            }
            double media = soma / n; //Variável media
            Console.WriteLine("O Preço Médio é: R$" + media.ToString("F2", CultureInfo.InvariantCulture)); //Saída do Preço Médio
            Console.ReadKey();
        } 
    }
}
