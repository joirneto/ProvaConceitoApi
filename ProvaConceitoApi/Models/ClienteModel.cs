using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaConceitoApi.Models
{
    public class ClienteModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }
    }
}
