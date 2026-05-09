using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Vendinha.Models;

namespace Vendinha.Services
{
    public class ClienteService
    {
        private List<Cliente> list = new List<Cliente>();

        public bool Validar(Cliente cliente, out List<ValidationResult> erros)
        {
            erros = new List<ValidationResult>();

            if (cliente == null)
            {
                erros.Add(new ValidationResult("O cliente não foi enviado"));
                return false;
            }

            return erros.Count == 0;
        }

        public bool Criar(Cliente cliente)
        {

            list.Add(cliente);

        }
    }
}
