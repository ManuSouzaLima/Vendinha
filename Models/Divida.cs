using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vendinha.Models
{
    public class Divida
    {
        private float Valor { get; set; }
        private bool Situacao { get; set; }
        private DateTime DataCriacao { get; set; }
        private DateTime DataPagamento { get; set; }

        private string SituacaoPagamento
        {
            get
            {
                if (Situacao)
                {
                    return "Pago";

                }
                else
                {
                    return "Em aberto";
                }
            }
        }

        public virtual void printDividas()
        {
            Console.WriteLine("Valor: {0}", Valor);
            Console.WriteLine("Situação: {0}", SituacaoPagamento);
            Console.WriteLine("Data da Divida: {0:dd/MM/yyyy}", DataCriacao);
            Console.WriteLine("Data de Pagamento: {0:dd/MM/yyyy}", DataPagamento);
        }
    }
}
