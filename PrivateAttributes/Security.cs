using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAttributes
{
    internal class Security
    {
        // Public & private Attr/Properties
        public string CompanyName;

        private string PrivateDocs = "Security Risk High";

        public string PublicDocs;

        private string Secrates = "This is not publickly available";

        public string GetPrivateDocs()
        {
            return PrivateDocs;
        }

        public string GetSecrates()
        {
            return Secrates;
        }


    }
}
