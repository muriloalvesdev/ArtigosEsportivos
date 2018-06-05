using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim3Semestre_Original_.Classes
{
    public class FormatarTextBox
    {
        public String Cnpj()
        {
            return "99,999,999/9999-99";
        }
        public String DataNascimento()
        {
            return "99/99/9999";
        }
        public String Cpf()
        {
            return "999,999,999-99";
        }
        public String Rg()
        {
            return "99,999,999,9";
        }
        public String TelFixo()
        {
            return "(99) 9999-9999";
        }
        public String Cel()
        {
            return "(99) 9-9999-9999";
        }
        public String Cep()
        {
            return "99,999-999";
        }
    }
}
