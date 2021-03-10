using Microsoft.EntityFrameworkCore;
using RAS.Business.Interfaces;
using RAS.Business.Models;
using RAS.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RAS.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(BookShopDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .Include(e => e.Fornecedor)
                .FirstOrDefaultAsync(f=>f.FornecedorId == fornecedorId);
        }
    }
}
