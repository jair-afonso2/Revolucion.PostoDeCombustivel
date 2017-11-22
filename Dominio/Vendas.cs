using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dominio
{
    public class Vendas : IAcao
    {
        
        public string Produto { get; set; }
        public double Volume { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Cliente { get; set; }

        public Vendas(string Produto, double Volume, double Valor, DateTime Data, string Cliente)
        {
            this.Produto = Produto;
            this.Volume = Volume;
            this.Valor = Valor;
            this.Data = Data;
            this.Cliente = Cliente;
        }
<<<<<<< HEAD

        public Vendas()
        {
        }

=======
        public Vendas()
        {
            
        } 
        
>>>>>>> ad082b65b0c3a0256cac8c5e9ccb94dea7968f1e
        public string Cadastro()
        {
            string efetuado = "";
            StreamWriter arquivo = null;
            try
            {
                arquivo = new StreamWriter("Vendas.csv", true);
                arquivo.WriteLine(Produto + ";" + Volume + ";" + Valor + ";" + Data + ";" + Cliente);
                efetuado = "Produto: " + Produto +
                           "\nVolume: " + Volume +
                           "\nValor: " + Valor +
                           "\nData do cadastro: " + Data +
                           "\nCliente: " + Cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o arquivo." + ex.Message);
            }
            finally
            {
                arquivo.Close();
            }
            return efetuado;
        }

<<<<<<< HEAD
        public string Consulta(string Produto)
        {
            string resultado = "Produto não encontrado.";
=======
        // public string Consulta()
        // {
        //     string resultado = "Título não encontrado.";
        //     StreamReader ler = null;
        //     try
        //     {
        //         ler = new StreamReader("Vendas.csv", Encoding.Default);
        //         string linha = "";
        //         while((linha = ler.ReadLine()) != null){
        //             string[] dados = linha.Split(';');
        //             if(dados[0].ToUpper() == Produto.ToUpper()){
        //                 resultado = "Produto: " + dados[0] +
        //                             "\nVolume: " + dados[1] +
        //                             "\nValor: " + dados[2] +
        //                             "\nData do cadastro: " + dados[3] +
        //                             "\nCliente: " + dados[4];
        //                 break;
        //             }
        //         }
        //     }
        //     catch(Exception ex){
        //         resultado = "Erro ao tentar ler o arquivo." + ex.Message;
        //     }
        //     finally{
        //         ler.Close();
        //     }
        //     return resultado;
        // }
        public List<string[]> Consulta(string nome){
            List<string[]> resultado = new List<string[]>();
>>>>>>> ad082b65b0c3a0256cac8c5e9ccb94dea7968f1e
            StreamReader ler = null;
            try{
                ler = new StreamReader("Vendas.csv", Encoding.Default);
                string linha = "";
                while((linha = ler.ReadLine()) != null){
                    string[] dados = linha.Split(';');
<<<<<<< HEAD
                    if(dados[0].ToUpper() == Produto.ToUpper()){
                        resultado = "Produto: " + dados[0] +
                                    "\nVolume: " + dados[1] +
                                    "\nValor: " + dados[2] +
                                    "\nData do cadastro: " + dados[3] +
                                    "\nCliente: " + dados[4] ;
                        break;
                    }
                }
            }
            catch(Exception ex){
                resultado = "Erro ao tentar ler o arquivo." + ex.Message;
            }
            finally{
                ler.Close();
            }
            return resultado;
        }

        public string Consulta(DateTime data)
        {
            string resultado = "Data não encontrada.";
            StreamReader ler = null;
            try
            {
                ler = new StreamReader("Vendas.csv", Encoding.Default);
                string linha = "";
                while((linha = ler.ReadLine()) != null){
                    string[] dados = linha.Split(';');
                    if(dados[3].Contains(data.ToShortDateString())){
                        resultado = "Produto: " + dados[0] +
                                    "\nVolume: " + dados[1] +
                                    "\nValor: " + dados[2] +
                                    "\nData do cadastro: " + dados[3] +
                                    "\nCliente: " + dados[4] ;
                        break;
=======
                    if(dados[4] == nome){
                        resultado.Add(dados);
>>>>>>> ad082b65b0c3a0256cac8c5e9ccb94dea7968f1e
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