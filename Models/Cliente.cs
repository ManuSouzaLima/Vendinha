using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Vendinha.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        private string Nome { get; set; }

        [Required(ErrorMessage = "O CPF do cliente é obrigatório")]
        [RegularExpression("^\\d{11}$\r\n")]
        private string Cpf { get; set; }

        [Required(ErrorMessage = "A data de nascimento do cliente é obrigatória")]
        private DateTime DataNascimento { get; set; }

        [RegularExpression("/^[a-z0-9.]+@[a-z0-9]+\\.[a-z]+\\.([a-z]+)?$/i\r\n")]
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
