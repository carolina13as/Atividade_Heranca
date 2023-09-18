using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeHeranca.Clasess
{
    internal class Conta
    {
        public int NumeroCont { get; set; }
        public int Agencia { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta(int numeroConta, int agencia, string nome, double saldo)
        {
           NumeroCont = numeroConta;
            Agencia=agencia;
            Nome = nome;
            Saldo = saldo;

        }


        public virtual void  Sacar( double saque)
        {
            try
            {
                if (Saldo < saque)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                else
                {

                    Console.WriteLine(Saldo -= saque);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
           
            
          

        }
        public virtual void Deposito(double deposito)
        {
            try
            {
                if (deposito >= 0)
                {
                    Console.WriteLine(Saldo += deposito);
                }
                else { Console.WriteLine("Operação invalida"); }
             
            }
           catch(Exception ex)
            {
                Console.Write($"Erro: {ex.Message}");
            }
        }

    }
}
