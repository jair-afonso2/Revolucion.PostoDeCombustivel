using System;
using Dominio;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Revolucion - Postos de Combustivel");

            int opcao = 0;
            do
            {
                Console.WriteLine("\nDigite a opção:\n");
                System.Console.WriteLine("1 - Cadastrar");
                System.Console.WriteLine("2 - Realizar Venda");
                System.Console.WriteLine("3 - Consultar");
                System.Console.WriteLine("9 - Sair\n");

                opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int opcaoCadastrar = 0;

                        do
                        {

                            Console.WriteLine("\nCadastrar:\n");
                            System.Console.WriteLine("1 - Cliente");
                            System.Console.WriteLine("2 - Fornecedor");
                            System.Console.WriteLine("3 - Produto");
                            System.Console.WriteLine("9 - Voltar\n");

                            opcao = Convert.ToInt16(Console.ReadLine());

                            switch (opcaoCadastrar)
                            {
                                case 1:
                                    bool cadastrosucesso = false;

                                    System.Console.Write("\nRazão Social: ");
                                    string razaosocial = Console.ReadLine();
                                    System.Console.Write("CNPJ: ");
                                    string cnpj = Console.ReadLine();
                                    System.Console.Write("Email: ");
                                    string email = Console.ReadLine();
                                    System.Console.Write("Telefone: ");
                                    string telefone = Console.ReadLine();
                                    Endereco endereco = new Endereco();

                                    System.Console.Write("Data (dd/mm/aaaa): ");

                                    DateTime data = Convert.ToDateTime(Console.ReadLine());

                                    System.Console.Write("Classificação: ");

                                    int classificacao = Convert.ToInt16(Console.ReadLine());
                                    break;

                                case 2:
                                    break;

                                case 3:

                                    break;

                                case 9:
                                    break;

                                default:
                                    System.Console.WriteLine("Opção inválida.\n");
                                    break;
                            }

                        } while (opcaoCadastrar != 9);

                        break;

                    case 2:
                        break;

                    case 3:
                        int opcaoConsultar = 0;

                        do
                        {

                            Console.WriteLine("\nConsultar:\n");
                            System.Console.WriteLine("1 - Histórico de Vendas");
                            System.Console.WriteLine("2 - Clientes");
                            System.Console.WriteLine("3 - Fornecedores");
                            System.Console.WriteLine("9 - Voltar\n");

                            opcao = Convert.ToInt16(Console.ReadLine());

                            switch (opcaoConsultar)
                            {
                                case 1:
                                    break;

                                case 2:
                                    break;

                                case 3:
                                    break;

                                case 9:
                                    break;

                                default:
                                    System.Console.WriteLine("Opção inválida.\n");
                                    break;
                            }

                        } while (opcaoConsultar != 9);
                        break;

                    case 9:
                        break;

                    default:
                        System.Console.WriteLine("Opção inválida.\n");
                        break;
                }

            } while (opcao != 9);
        }
    }
}
