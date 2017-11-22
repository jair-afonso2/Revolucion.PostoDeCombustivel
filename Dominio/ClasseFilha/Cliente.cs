using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dominio.ClasseFilha
{
    public class Cliente : PJ, IAcao
    {
        //Construtores da classe:
        public Cliente(){}
        public Cliente(string razaoSocial, string cnpj, string email, string telefone, Endereco endereco)
        {
            base.Cnpj = cnpj;
            base.Email = email;
            base.endereco = endereco;
            base.RazaoSocial = razaoSocial;
            base.Telefone = telefone;
        }

        //Métodos de Cadastro e Consulta
        public string Cadastro()
        {
<<<<<<< HEAD
            var cl_arquivo = new StreamWriter("clientes.csv", true, Encoding.Default);
            string composicao = "";
=======
            var cl_arquivo = new StreamWriter("Clientes.csv", true, Encoding.Default);
            string msg = "";
>>>>>>> ad082b65b0c3a0256cac8c5e9ccb94dea7968f1e
            string linha_cliente = "";
            try{
                if(new FileInfo("Clientes.csv").Length == 0){
                    cl_arquivo.WriteLine("CNPJ;RazãoSocial;Email;Telefone;Endereço");
                }
                linha_cliente = this.Cnpj + ";" + this.RazaoSocial + ";" + 
                                    this.Email + ";" + this.Telefone + ";" + this.endereco.EscreveEndereco();

                cl_arquivo.WriteLine(linha_cliente);

                composicao = "Cadastro efetuado." + 
                        "\nCNPJ: " + this.Cnpj + 
                        "\nRazão Social: " + this.RazaoSocial + 
                        "\nEmail: " + this.Email + 
                        "\nTelefone: " + this.Telefone + 
                        "\nEndereço: " + this.endereco;
            
                }
            catch(Exception ex){
                throw new Exception("Erro ao cadastrar cliente." + ex.Message);
                }
            finally{
                cl_arquivo.Close();
            }
            
            return linha_cliente;
        }
    

        // public string Consulta()
        // {
        //     using(var leitor = new StreamReader("Clientes.csv", true)){
        //         string composicao = "";
        //         string linha = "";
        //         try{
        //             while((linha = leitor.ReadLine()) != null){
        //                 string[] cliente = linha.Split(';');
        //                 if(cliente[0] == this.Cnpj){
        //                     this.Email = cliente[2];
        //                     this.RazaoSocial = cliente[1];
        //                     this.Telefone = cliente[3];
        //                     this.endereco = ConverterEndereco(cliente[4]);                        
        //                     }
        //             composicao = "CNPJ: " + this.Cnpj + 
        //                                 "\nRazão Social: " + this.RazaoSocial +
        //                                 "\nEmail: " + this.Email +
        //                                 "\nTelefone: " + this.Telefone + 
        //                                 "\nEndereço: " + cliente[4];
        //             }
        //         }
        //         catch(Exception ex){
        //             throw new Exception("Erro ao procurar cliente." + ex.Message);
        //         }
        //     return composicao;
        //     }
        // }

        public List<string[]> Consulta(string nome){
            List<string[]> resultado = new List<string[]>();
            StreamReader ler = null;
            try{
                ler = new StreamReader("Clientes.csv", Encoding.Default);
                string linha = "";
                while((linha = ler.ReadLine()) != null){
                    string[] dados = linha.Split(';');
                    if(dados[1] == nome){
                        resultado.Add(dados);
                    }
                }
            }
            catch(Exception ex){
                string erro = "Erro ao tentar ler o arquivo." + ex.Message;
            }
            finally{
                ler.Close();
            }
            return resultado;
        }

        public string Consulta()
        {
            throw new NotImplementedException();
        }
    }
}