using System;

namespace Dominio
{
    public abstract class PJ
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public Endereco endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public bool VerificarCnpj(string cnpj)
        {
            //Retira os caracteres especiais do CNPJ
            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "");

            //Verifica se o CNPJ possui 14 caracteres
            if (cnpj.Length != 14)
            {
                return false;
            }

            //Declara um array com valores a serem multiplicados para encontrar o primeiro caractere
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            //Declara um array com valores a serem multiplicados para encontrar o segundo caractere
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };


            string tempCnpj, digito;
            int soma = 0, resto = 0;

            //Atribui a variavel os 12 primeiros caracteres do cnpj
            tempCnpj = cnpj.Substring(0, 12);

            //Percorre os 12 caracteres e otem a soma
            for (int i = 0; i < 12; i++)
            {
                //multiplica o valor do array na poição i ao caracter na posição i
                soma += Convert.ToInt16(tempCnpj[i].ToString()) * multiplicador1[i];
            }

            //obtêm o resto da divisão da soma por 11
            resto = soma % 11;

            //Caso o resto seja menor que 2 atribui 0 e caso seja maior atribui ao valor 11 - resto
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //Atribui o valor do resto a variável digito
            digito = resto.ToString();
            //Concatena o cnpj com 12 caracteres ao resto para validar o segundo dígito
            tempCnpj = tempCnpj + digito;

            soma = 0;
            //Percorre os 13 caracteres e otem a soma
            for (int i = 0; i < 13; i++)
            {
                //multiplica o valor do array na poição i ao caracter na posição i
                soma += Convert.ToInt16(tempCnpj[i].ToString()) * multiplicador2[i];
            }

            //Caso o resto seja menor que 2 atribui 0 e caso seja maior atribui ao valor 11 - resto
            resto = soma % 11;

            //Caso o resto seja menor que 2 atribui 0 e caso seja maior atribui ao valor 11 - resto
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //Atribui o valor do resto a variável digito
            digito = resto.ToString();

            //Verifica se o digito é igual aos do cnpj, caso seja retorna true caso contrário retorna false
            return cnpj.EndsWith(digito);
        }
        public Endereco ConverterEndereco(string end_str)
        {
            string[] array = end_str.Split(',');
            return new Endereco(array[0], array[1], array[2], array[3], array[4], array[5], array[6]);
        }
    }
}