using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Dominio
{
    public class OpenLibraryResponse
    {
        public int Start { get; set; }
        public int NumFound { get; set; }
        public List<Docs> Docs { get; set; }
    }
}
