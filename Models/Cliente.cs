using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Vendinha.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "O nome do aluno é obrigatório")]
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Email { get; set; }

        private int Idade
        {
            get
            {
                var dataHoje = DateTime.Today;
                var anos = dataHoje.Year - DataNascimento.Year;
                var diaAnoNascimento = dataHoje.AddYears(-anos);

                if (DataNascimento > diaAnoNascimento)
                {
                    anos--;
                }
                return anos;
            }
        }


        public virtual void printDados()
        {
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("Idade: {0}", Idade);
            Console.WriteLine("CPF: {0}", Cpf);
            Console.WriteLine("Data Nascimento: {0:dd/MM/yyyy}", DataNascimento);
            Console.WriteLine("Email: {0}", Email);
        }
    }
}
