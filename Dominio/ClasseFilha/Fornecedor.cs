using System;
using System.IO;
using System.Text;

namespace Dominio.ClasseFilha
{
    public class Fornecedor : PJ, IAcao
    {
        //Construtores da classe:
        public Fornecedor(){}
        public Fornecedor(string razaoSocial, string cnpj, string email, string telefone, Endereco endereco)
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
            var cl_arquivo = new StreamWriter("Fornecedores.csv", true, Encoding.Default);
            string msg = "";
            string linha_fornecedor = "";
            try{
                if(new FileInfo("Fornecedores.csv").Length == 0){
                    cl_arquivo.WriteLine("CNPJ;RazãoSocial;Email;Telefone;Endereço");
                }
                linha_fornecedor = this.Cnpj + ";" + this.RazaoSocial + ";" + 
                                    this.Email + ";" + this.Telefone + ";" + this.endereco;

                cl_arquivo.WriteLine(linha_fornecedor);

                msg = "Cadastro efetuado." + 
                        "\nCNPJ: " + this.Cnpj + 
                        "\nRazão Social: " + this.RazaoSocial + 
                        "\nEmail: " + this.Email + 
                        "\nTelefone: " + this.Telefone + 
                        "\nEndereço: " + this.endereco;
            
                }
            catch(Exception ex){
                throw new Exception("Erro ao cadastrar fornecedor." + ex.Message);
                }
            finally{
                cl_arquivo.Close();
            }
            
            return linha_fornecedor;
        }
    

        public string Consulta()
        {
            using(var leitor = new StreamReader("Fornecedores.csv", true)){
                string composicao = "";
                string linha = "";
                try{
                    while((linha = leitor.ReadLine()) != null){
                        string[] fornecedor = linha.Split(';');
                        if(fornecedor[0] == this.Cnpj){
                            this.Email = fornecedor[2];
                            this.RazaoSocial = fornecedor[1];
                            this.Telefone = fornecedor[3];
                            this.endereco = ConverterEndereco(fornecedor[4]);                        
                            }
                    composicao = "CNPJ: " + this.Cnpj + 
                                        "\nRazão Social: " + this.RazaoSocial +
                                        "\nEmail: " + this.Email +
                                        "\nTelefone: " + this.Telefone + 
                                        "\nEndereço: " + fornecedor[4];
                    }
                }
                catch(Exception ex){
                    throw new Exception("Erro ao procurar fornecedor." + ex.Message);
                }
            return composicao;
            }
        }
    }
}