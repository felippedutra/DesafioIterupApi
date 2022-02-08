using DesafioIterupApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioIterupApi.Respositories.Interface
{
    public interface ITipoEtapaRepository
    {
        List<TipoEtapaModel> TiposEtapas();
    }
}
