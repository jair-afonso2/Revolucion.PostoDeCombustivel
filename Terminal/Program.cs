using System;
using System.Collections.Generic;
using Dominio;
using Dominio.ClasseFilha;

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
                Console.WriteLine("\nDigite a opção:");
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

                            opcaoCadastrar = Convert.ToInt16(Console.ReadLine());

                            if (opcaoCadastrar == 1 || opcaoCadastrar == 2)
                            {
                                System.Console.Write("\nRazão Social: ");
                                string razaosocial = Console.ReadLine();
                                System.Console.Write("CNPJ: ");
                                string cnpj = Console.ReadLine();
                                System.Console.Write("Email: ");
                                string mail = Console.ReadLine();
                                System.Console.Write("Telefone: ");
                                string telefone = Console.ReadLine();
                                System.Console.Write("Logradouro: ");
                                string EndLogradouro = Console.ReadLine();
                                System.Console.Write("Numero: ");
                                string EndNumero = Console.ReadLine();
                                System.Console.Write("Complemento: ");
                                string EndComplemento = Console.ReadLine();
                                System.Console.Write("Bairro: ");
                                string EndBairro = Console.ReadLine();
                                System.Console.Write("Cidade: ");
                                string EndCidade = Console.ReadLine();
                                System.Console.Write("Estado: ");
                                string EndEstado = Console.ReadLine();
                                System.Console.Write("CEP: ");
                                string EndCep = Console.ReadLine();

                                Endereco endereco = new Endereco(EndLogradouro, EndNumero, EndComplemento, EndBairro, EndCidade, EndEstado, EndCep);

                                switch (opcaoCadastrar)
                                {
                                    case 1:
                                        Cliente Nomecliente = new Cliente(razaosocial, cnpj, mail, telefone, endereco);
                                        Nomecliente.Cadastro();
                                        break;

                                    case 2:
                                        Fornecedor fornecedor = new Fornecedor(razaosocial, cnpj, mail, telefone, endereco);
                                        fornecedor.Cadastro();
                                        break;

                                }
                            }


                            switch (opcaoCadastrar)
                            {
                                case 3:
                                    System.Console.Write("\nProduto: ");
                                    string NomeProduto = Console.ReadLine();
                                    System.Console.Write("Preço: ");
                                    double preco = Convert.ToDouble(Console.ReadLine());

                                    Produtos Objproduto = new Produtos(NomeProduto, preco);
                                    Objproduto.Cadastro();
                                    break;

                                case 9:
                                    break;

                            }

                        } while (opcaoCadastrar != 9);

                        break;

                    case 2:
                        System.Console.Write("\nProduto: ");
                        string produto = Console.ReadLine();
                        System.Console.Write("Volume: ");
                        double volume = Convert.ToDouble(Console.ReadLine());
                        System.Console.Write("Valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        System.Console.Write("Data (dd/mm/aaaa hh:mm:ss): ");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        System.Console.Write("Cliente: ");
                        string cliente = Console.ReadLine();

                        Vendas venda = new Vendas(produto, volume, valor, data, cliente);
                        venda.Cadastro();
                        break;

                    case 3:
                        int opcaoConsultar = 0;

                        do
                        {

                            Console.WriteLine("\nConsultar:");
                            System.Console.WriteLine("1 - Histórico de Vendas");
                            System.Console.WriteLine("2 - Clientes");
                            System.Console.WriteLine("3 - Fornecedores");
                            System.Console.WriteLine("9 - Voltar\n");

                            opcaoConsultar = Convert.ToInt16(Console.ReadLine());
<<<<<<< HEAD
                            string resultado = "";

                            switch (opcaoConsultar)
                            {
                                case 1:
                                    System.Console.Write("\nData: ");
                                    DateTime datas = Convert.ToDateTime(Console.ReadLine());
                                    Vendas ObjVenda = new Vendas();
                                    resultado = ObjVenda.Consulta(datas);
                                    System.Console.WriteLine("\n" + resultado);  
=======
                            
                            switch (opcaoConsultar)
                            {
                                case 1:
                                    System.Console.Write("\nNome do cliente: ");
                                    string nome_venda = (Console.ReadLine());
                                    Vendas ObjVenda = new Vendas();
                                    List<string[]> venda_list = ObjVenda.Consulta(nome_venda);
                                        if(venda_list.Count != 0){
                                            foreach(string[] item in venda_list){
                                            Console.WriteLine("Produto: " + item[0] +
                                                "\nVolume: " + item[1] +
                                                "\nValor: " + item[2] +
                                                "\nData do cadastro: " + item[3] +
                                                "\nCliente: " + item[4] + "\n");
                                            }
                                        }
                                        else{
                                            Console.WriteLine("\n\nNão há histórico de vendas para o cliente pesquisado.");
                                        }
>>>>>>> ad082b65b0c3a0256cac8c5e9ccb94dea7968f1e
                                    break;

                                case 2:
                                    System.Console.Write("\nNome do cliente: ");
                                    string nome_cliente = (Console.ReadLine());
                                    Cliente ObjCliente = new Cliente();
                                    List<string[]> cliente_list = ObjCliente.Consulta(nome_cliente);
                                        if(cliente_list.Count != 0){
                                            foreach(string[] item in cliente_list){
                                            Console.WriteLine("CNPJ: " + item[0] +
                                                "\nRazão Social: " + item[1] +
                                                "\nEmail: " + item[2] +
                                                "\nTelefone: " + item[3] +
                                                "\nEndereço: " + item[4] + "\n");
                                            }
                                        }
                                        else{
                                            Console.WriteLine("Cliente não encontrado.");
                                        }
                                    break;

                                case 3:
                                    System.Console.Write("\nNome do cliente: ");
                                    string nome_fornecedor = (Console.ReadLine());
                                    Fornecedor ObjFornecedor = new Fornecedor();
                                    List<string[]> fornecedor_list = ObjFornecedor.Consulta(nome_fornecedor);
                                        if(fornecedor_list.Count != 0){
                                            foreach(string[] item in fornecedor_list){
                                            Console.WriteLine("CNPJ: " + item[0] +
                                                "\nRazão Social: " + item[1] +
                                                "\nEmail: " + item[2] +
                                                "\nTelefone: " + item[3] +
                                                "\nEndereço: " + item[4] + "\n");
                                            }
                                        }
                                        else{
                                            Console.WriteLine("Fornecedor não encontrado.");
                                        }
                                    break;

                                default:
                                    System.Console.WriteLine("Opção inválida.\n");
                                    break;
                            }

                        } while (opcaoConsultar != 9);
                        break;

                    default:
                        System.Console.WriteLine("Opção inválida.\n");
                        break;
                }

            } while (opcao != 9);
        }
    }
}