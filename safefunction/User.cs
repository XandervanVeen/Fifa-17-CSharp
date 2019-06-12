using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safefunction
{
    public class User
    {
       public string Username;
       public ulong Credits;
       public List<Savedbet> Savedbets = new List<Savedbet>();

        public override string ToString()
        {
            return Username;
        }
    }
}
