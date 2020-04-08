using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class Email
    {
        int id;
        string email;
        string descEmail = null;

        public int Id { get => id; set => id = value; }
        public string Mail { get => email; set => email = value; }
        public string DescEmail { get => descEmail; set => descEmail = value; }
    }
}
