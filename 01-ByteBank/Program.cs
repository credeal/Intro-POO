using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaGabriela =  new ContaCorrente(111, 111111);
            contaGabriela.Titular.nome = "Gabriela Krapovics";
            contaGabriela.Saldo = 100;

            ContaCorrente contaLucas = new ContaCorrente(222, 222222);
            contaLucas.Titular.nome = "Lucas Mitsuri";
            contaLucas.Saldo = 100;

            Console.WriteLine("Valores Iniciais");
            Console.WriteLine(contaGabriela);
            Console.WriteLine(contaLucas);

            Console.WriteLine("Utilizando o método Sacar (50)");
            contaGabriela.Sacar(50);
            Console.WriteLine(contaGabriela);

            Console.WriteLine("Utilizando o método Depositar(200)");
            contaGabriela.Depositar(200);
            Console.WriteLine(contaGabriela);

            Console.WriteLine("Utilizando o método Transferir(50)");
            contaGabriela.Transferir(contaLucas, 50);
            Console.WriteLine(contaGabriela);
            Console.WriteLine(contaLucas);

            Console.WriteLine($"Número de contas criadas: {ContaCorrente.TotalContas}");

            Console.ReadLine();
        }
    }
}
