using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_singleton
{
    class Singelton
    {
        private static Singelton single = null;

        protected Singelton()
        {

        }

        public static Singelton Initialize()
        {
            {
                if (single == null)
                {
                    single = new Singelton();
                    return single;
                }
                return single;
            }
        }
    }
}
