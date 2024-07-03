using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreetSnack.Context;
using StreetSnack.Models;
using StreetSnack.Repositories.Interfaces;

namespace StreetSnack.Repositories
{
    public class CategoriaRepository:ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context){
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}