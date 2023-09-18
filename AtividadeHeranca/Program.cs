
using AtividadeHeranca.Clasess;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Qual conta deseja criar: \n1-Empressaria\n2-Estudante\n3-Normal\n4-Sair");
                int op = Convert.ToInt32(Console.ReadLine());
                int numeC;
                int agen;
                string nome;
                double saldo;
                double saque;
                double deposito;
                double TaxaAnual = 100;
                double LimEmp = 10000;
                double valor;

                if (op == 1)
                {

                    Console.Write("Digite seu numero da conta: ");
                    numeC = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite sua egencia: ");
                    agen = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite seu nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    Console.Write("Digite seu saldo atual: ");
                    saldo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor do saque: ");
                    saque = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite seu deposito: ");
                    deposito = Convert.ToDouble(Console.ReadLine());

                    Empresa e = new Empresa(TaxaAnual, LimEmp, numeC, agen, nome, saldo);



                    Console.WriteLine("Deseja fazer um emprestimo:\n1-Sim\n2-Não");
                    int op2 = Convert.ToInt32(Console.ReadLine());


                    if (op2 == 1)
                    {
                        Console.Write("Digte o valor do emprestimo:");
                        valor = Convert.ToDouble(Console.ReadLine());


                        e.Emprestimo(valor);
                        e.Emprestimo(valor);

                        Console.WriteLine($" Você ainda pode pegar emprestado: {e.TotalEmp}\n");
                    }
                   

                   
                    Console.Write($"Seu saldo após o saque é: ");
                    e.Sacar(saque);
                    Console.WriteLine("\n");
                    Console.Write($"Seu saldo após o deposito é: ");
                    e.Deposito(deposito);
                    Console.WriteLine("\n");

                }




                else if (op == 2)
                {
                    Console.Write("Digite seu numero da conta: ");
                    numeC = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite sua egencia: ");
                    agen = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite seu nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    Console.Write("Digite seu saldo atual: ");
                    saldo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor do saque: ");
                    saque = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite seu deposito: ");
                    deposito = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite seu cpf:");
                    string cpf = Console.ReadLine();
                    Console.Write("Digite sua instituição:");
                    string inst = Console.ReadLine();



                    Aluno a = new Aluno(cpf, inst, numeC, agen, nome, saldo);
                    
                    Console.Write("Seu saque foi de: ");
                    a.Sacar(saque);
                    Console.WriteLine("\n");
                    Console.Write($"Seu saldo após o deposito é: ");
                    a.Deposito(deposito);
                    Console.WriteLine("\n");
                }
                else if (op == 3)
                {
                    Console.Write("Digite seu numero da conta: ");
                    numeC = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite sua egencia: ");
                    agen = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite seu nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    Console.Write("Digite seu saldo atual: ");
                    saldo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor do saque: ");
                    saque = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite seu deposito: ");
                    deposito = Convert.ToDouble(Console.ReadLine());
                    
                    Conta c = new Conta(numeC, agen, nome, saldo);

                    Console.Write("Seu saldo após o saque é: ");
                    c.Sacar(saque);
                    Console.WriteLine("\n");
                    Console.Write($"Seu saldo após o deposito é: ");
                    c.Deposito(deposito);
                    Console.WriteLine("\n");
                }


                else if (op == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção invalida");
                }

            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        

        

        
    }
}
