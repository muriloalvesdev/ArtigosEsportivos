using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim3Semestre_Original_.Classes
{
    public class Fornecedor
    {
        public int id_fornecedor { get; set; }
        public String nome { get; set; }
        public String contato { get; set; }
        public String razaoSocial { get; set; }
        public String cnpj { get; set; }
        public String logradouro { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String complemento { get; set; }
        public String cep { get; set; }
    }
}
