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
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Entrada dos elementos no vetor pelo usuário
                vect[i] = new Produto { Name = name, Price = price };
            }
            double soma = 0.0; //Variável soma    
            for(int i= 0; i < n; i++) //Utilização do for para percorrer o vetor
            {
                soma += vect[i].Price; //Somatoriados elementos inseridos
            }
            Console.ReadKey();
        } 
    }
}
