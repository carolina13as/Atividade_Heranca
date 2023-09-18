using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeHeranca.Clasess
{
    internal class Aluno:Conta
    {

        public string CPf { get; set; }
        public double ChequeEspe { get; set; }
        public string Instituicao { get; set; }

        public Aluno (string cPf, string instituicao, int numeroConta, int agencia, string nome, double saldo):
            base(numeroConta, agencia, nome, saldo)
        {
            CPf = cPf;
            ChequeEspe = 1000;
            Instituicao = instituicao;
        }

        public override void Sacar(double valor)
        {
            try
            {

                if (this.Saldo + ChequeEspe >= valor)
                {
                    Console.Write(this.Saldo -= valor);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

        }
    }
}
