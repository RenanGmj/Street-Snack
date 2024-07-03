using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreetSnack.Models;

namespace StreetSnack.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias{ get; }
    }
}