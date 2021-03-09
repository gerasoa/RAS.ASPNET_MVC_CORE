using System;
using System.Collections.Generic;
using System.Text;

namespace RAS.Business.Models
{
    public class Suplier : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Product> Products { get; set; }
    }
}
