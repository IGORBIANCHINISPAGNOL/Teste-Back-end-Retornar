using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conection
{
    public class Conection
    {
       
#if DEBUG
        private static string xConection = @"Data source=IGOR;initial catalog=DB_GENERATOR;User ID=sa;Password=123456;Integrated Security=false;Encrypt=False;Connect Timeout=30";
#elif RELEASE
        private static string xConection = @"Data source=IGOR;initial catalog=DB_DevTechNolog;User ID=sa;Password=123456;Integrated Security=false;Encrypt=False;Connect Timeout=30";      
#endif

        public static string StrCon
        {
            get { return xConection; }
        }
    }
}
