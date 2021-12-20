using ProjetoRecode.Enum;
using System;
namespace ProjetoRecode.Models
{
    public class Cadastro
    {
        public int CodigoCliente { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string E_mail { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public char Cep { get; set; }
        public Situacao Situacao { get; set; }
    }
}

