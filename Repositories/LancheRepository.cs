using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StreetSnack.Context;
using StreetSnack.Models;
using StreetSnack.Repositories.Interfaces;

namespace StreetSnack.Repositories
{
    public class LancheRepository:ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context){
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria );
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p =>
        p.IsLanchePreferido).Include(c => c.Categoria );
        public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(I => I.LancheId == lancheId);

    }
}