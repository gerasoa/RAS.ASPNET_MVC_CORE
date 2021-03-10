using System;
using System.Collections.Generic;
using System.Text;

namespace RAS.Business.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Street { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        /* EF Relation */
        public Fornecedor Fornecedor { get; set; }
    }
}
