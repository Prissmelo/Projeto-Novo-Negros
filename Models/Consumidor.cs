using NEGRASM.Enum;
using NEGRASM.Enum2;
using System;

namespace NEGRASM.Models
{
    public class Consumidor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public int Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
    }
}
