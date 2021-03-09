using System;
using System.Collections.Generic;
using System.Text;

namespace RAS.Business.Models
{
    public class Product : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Suplier Suplier { get; set; }
    }
}
