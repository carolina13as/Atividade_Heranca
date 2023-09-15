
using AtividadeHeranca.Clasess;

public class Program
{
    static void Main(string[] args)
    {

        int numeC = 1;
        int agen = 02;
        string nome = "Carol";
        double saldo = 100;
        double saque = 10;
        double deposito = 20;
        double TaxaAnual = 5;
        double LimEmp = 500;
        double valor = 300;
    
        
        Empresa e = new Empresa( TaxaAnual,LimEmp, numeC, agen, nome, saldo);

        e.Emprestimo(valor);
        e.Emprestimo(valor);
        e.Sacar(saque);
        e.Deposito(deposito);

        Console.WriteLine(e.TotalEmp);


        
       
        string cpf = "111111111";
        string inst = "Ifro";
       

        Aluno a = new Aluno(cpf, inst, numeC,agen,nome,saldo);

        a.Sacar(valor);
    }
}
