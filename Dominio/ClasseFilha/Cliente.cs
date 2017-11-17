using System;
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
            var cl_arquivo = new StreamWriter("clientes.csv", true, Encoding.Default);
            string msg = "";
            string linha_cliente = "";
            try{
                if(new FileInfo("clientes.csv").Length == 0){
                    cl_arquivo.WriteLine("CNPJ;RazãoSocial;Email;Telefone;Endereço");
                }
                linha_cliente = this.Cnpj + ";" + this.RazaoSocial + ";" + 
                                    this.Email + ";" + this.Telefone + ";" + this.endereco;

                cl_arquivo.WriteLine(linha_cliente);

                msg = "Cadastro efetuado." + 
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
    

        public string Consulta()
        {
            using(var leitor = new StreamReader("clientes.csv", true)){
                string msg = "";
                string composicao = "";
                string linha = "";
                try{
                    while((linha = leitor.ReadLine()) != null){
                        string[] cliente = linha.Split(';');
                        if(cliente[0] == this.Cnpj){
                            this.Email = cliente[2];
                            this.RazaoSocial = cliente[1];
                            this.Telefone = cliente[3];
                            this.endereco = ConverterEndereco(cliente[4]);                        
                            }
                    }
                }
                catch(Exception ex){
                    throw new Exception("Erro ao procurar cliente." + ex.Message);
                }
                finally{
                    leitor.Close();
                }
            }
            throw new System.NotImplementedException();
        }
    }
}
