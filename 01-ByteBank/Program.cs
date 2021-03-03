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

            ContaCorrente contaGabriela =  new ContaCorrente();
            contaGabriela.titular.nome = "Gabriela Krapovics";
            contaGabriela.agencia = 111;
            contaGabriela.numero = 111111;
            contaGabriela.saldo = 100;

            ContaCorrente contaLucas = new ContaCorrente();
            contaLucas.titular.nome = "Lucas Mitsuri";
            contaLucas.agencia = 222;
            contaLucas.numero = 222222;
            contaLucas.saldo = 100;

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

            Console.ReadLine();
        }
    }
}
