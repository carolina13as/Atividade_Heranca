using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeHeranca.Clasess
{
    internal class Empresa:Conta
    {
        public double TaxaAnual { get; set; }
        public double LimeiteEmp { get; set; }
        public  double TotalEmp { get; set; }

        public Empresa(double taxaAnual, double limeiteEmp,  int numeroConta, int agencia,string nome,double saldo):base(numeroConta, agencia,nome,saldo )
        {
            TaxaAnual = taxaAnual;
            LimeiteEmp = limeiteEmp;
            TotalEmp = 0;
        }

        public void Emprestimo(double valor)
        {
            try
            {
                double rt = LimeiteEmp - TotalEmp;
                if (LimeiteEmp <= valor || valor > rt)
                {
                    Console.WriteLine(" O valor de empréstimo não pode ser consedido");

                }
                else
                {
                    TotalEmp += valor;
                    Saldo += valor;
                    Console.WriteLine("Empréstimo foi realizado com sucesso.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
           
        }

        public override void Sacar(double valor)
        {
            try
            {

                if (this.Saldo >= valor)
                {
                    if (valor > 5000)
                    {
                        Console.Write($"{Saldo -= valor + 5}"); 
                    }
                    else
                    {
                        Console.Write($"{Saldo -= valor}"); 
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            
        }


    }
}
