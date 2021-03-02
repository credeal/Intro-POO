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
            int um = 1;
            int dois = 1;

            ContaCorrente contaGabriela =  new ContaCorrente();
            contaGabriela.titular = "Gabriela Krapovics";
            contaGabriela.agencia = 111;
            contaGabriela.numero = 111111;
            contaGabriela.saldo = 0.00;

            ContaCorrente contaLucas = new ContaCorrente();
            contaLucas.titular = "Lucas Mitsuri";
            contaLucas.agencia = 222;
            contaLucas.numero = 222222;
            contaLucas.saldo = 0.00;

            Console.WriteLine(contaGabriela);
            Console.WriteLine(contaLucas);

            Console.WriteLine();

            //Tipo Valor
            Console.WriteLine($"1 é igual a 1 ? { um == dois}");

            //Tipo Referência
            Console.WriteLine($"Conta Gabriela é igual conta Lucas? { contaGabriela == contaLucas}");

            //Tipo Valor
            Console.WriteLine($"Conta Gabriela Saldo é igual conta Lucas Saldo? { contaGabriela.saldo == contaLucas.saldo}");

            //Tipo Referência - As duas contas tão sendo apontadas para o mesmo endereço da memoria
            contaLucas = contaGabriela;
            Console.WriteLine($"Conta Gabriela é igual conta Lucas? { contaGabriela == contaLucas}");


            Console.ReadLine();
        }
    }
}
