namespace Dominio
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }

        public Endereco(){}
        public Endereco(string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
        }
        public string EscreveEndereco(){
            string str = logradouro + ", " + numero + ", " + complemento + ", " + bairro + ", " + cidade + ", " + estado + ", " + cep;
            return str;
        }
    }
}