using PruebaProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaProgreso2.Interfaces
{
    internal interface IRecarga
    {
        List<Recarga> DevuelveListRecarga();
        Recarga DevuelveRecarg(int Id);
        Boolean CrearRecarga(Recarga recarga);
    }
}
