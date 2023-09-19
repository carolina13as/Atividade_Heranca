
using AtividadeHeranca.Clasess;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Qual conta deseja criar: \n1-Empresaria\n2-Estudante\n3-Normal\n4-Sair");
                int op = Convert.ToInt32(Console.ReadLine());
                int numeC = 1;
                int agen = 2;
                string nome;
                double saldo = 0;
                double saque;
                double deposito;
                double TaxaAnual = 100;
                double LimEmp = 10000;
                double valor;


                //Empresaria//
                if (op == 1)
                {

                    Console.Write("Digite seu nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    Empresa e = new Empresa(TaxaAnual, LimEmp, numeC, agen, nome, saldo);
                    numeC += 1;

                    while (true)
                    {
                        Console.WriteLine("1-Depositar\n2-Sacar\n3-Emprestimo\n4-Sair");
                        op = Convert.ToInt32(Console.ReadLine());
                        if (op == 1)
                        {
                            Console.Write("Digite seu deposito: ");
                            deposito = Convert.ToDouble(Console.ReadLine());
                            Console.Write($"Seu saldo após o deposito é: ");
                            e.Deposito(deposito);
                        }
                        else if (op == 2)
                        {

                            Console.Write("Digite o valor do saque: ");
                            saque = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Seu saldo após o saque é: ");
                            e.Sacar(saque);
                        }

                        else if (op == 3)
                        {
                            Console.Write("Digte o valor do emprestimo:");
                            valor = Convert.ToDouble(Console.ReadLine());
                            e.Emprestimo(valor);
                 
                            Console.WriteLine($" Você ainda pode pegar emprestado: {e.LimeiteEmp-e.TotalEmp}\n");
                        }
                        else if (op == 4)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    
                  
                   

                   
                   

                }



                //Estudante//
                else if (op == 2)
                {
                    Console.Write("Digite seu nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    Console.Write("Digite seu Cpf:");
                    string cpf = Console.ReadLine();
                    Console.Write("Digite sua instituição:");
                    string inst = Console.ReadLine();
                    Aluno a = new Aluno(cpf, inst, numeC, agen, nome, saldo);
                    numeC += 1;
                    while (true)
                    {
                         Console.WriteLine("1-Depositar\n2-Sacar\n3-Sair");
                        op = Convert.ToInt32(Console.ReadLine());
                        if(op == 1)
                        {
                            Console.Write("Digite seu deposito: ");
                            deposito = Convert.ToDouble(Console.ReadLine());
                            Console.Write($"Seu saldo após o deposito é: ");
                            a.Deposito(deposito);
                            Console.WriteLine("\n");
                        }
                        else if(op == 2)
                        {
                           
                            Console.Write("Digite o valor do saque: ");
                            saque = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Seu saldo após o saque é: ");
                            a.Sacar(saque);
                            Console.WriteLine("\n");
                        }
                        else if (op == 3)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    
                  
                }


                //Normal//
                else if (op == 3)
                {
                   
                    Console.Write("Digite seu nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    Conta c = new Conta(numeC, agen, nome, saldo);
                    numeC += 1;
                    while (true)
                    {
                        Console.WriteLine("1-Depositar\n2-Sacar\n3-Sair");
                        op = Convert.ToInt32(Console.ReadLine());
                        if(op == 1)
                        {
                            Console.Write("Digite seu deposito: ");
                            deposito = Convert.ToDouble(Console.ReadLine());
                            Console.Write($"Seu saldo após o deposito é: ");
                            c.Deposito(deposito);
                        }
                        else if(op == 2)
                        {
                           
                            Console.Write("Digite o valor do saque: ");
                            saque = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Seu saldo após o saque é: ");
                            c.Sacar(saque);
                        }
                        else if (op == 3)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                                    
                   
                
                    
                   

                   
                   
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
