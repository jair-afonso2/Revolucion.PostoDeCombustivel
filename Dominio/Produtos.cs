using System;
using System.IO;
using System.Text;

namespace Dominio
{
    public class Produtos : IAcao
    {
        public string produto { get; set; }
        public double preco { get; set; }
        public int estoque { get; set; }

        public Produtos()
        {}
        public Produtos(string produto, double preco, int estoque)
        {
            this.produto = produto;
            this.preco = preco;
            this.estoque = estoque;
        }

        public string Cadastro()
        {
            string composicao = "Produto: " + produto + "\nPreço: " + preco + "\nQuantidade em Estoque" + estoque;
            StreamWriter arquivo = new StreamWriter("Produtos.csv",true);
            if(!File.Exists("Produtos.csv"))
            {
                 arquivo.WriteLine("Nome do Produto;Preço;Estoque");
            }
            arquivo.WriteLine(produto + ";" + preco + ";" + estoque);
            arquivo.Close();
            return composicao;
        }

        public string Consulta()
        {
            StreamReader arquivo = new StreamReader("Produtos.csv", Encoding.Default);
            string linha = "";
            while((linha=arquivo.ReadLine())!=null)
            {
                string[] dados=linha.Split(';');
                if(dados[0]==produto)
                {
                    produto = dados[0];
                    preco = Convert.ToDouble(dados[1]);
                    estoque = Convert.ToInt16(dados[2]);
                    break;
                }
            }
            string composicao = "Produto: " + produto + "\nPreço: " + preco + "\nQuantidade em Estoque" + estoque;
            return composicao;
        }
    }
}
