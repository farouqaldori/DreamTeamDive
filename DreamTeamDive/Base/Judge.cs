using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Judge
    {

        public int id { get; set; }
        int authCode { get; set; }
        string name { get; set; }
        int competition { get; set; }

        public Judge()
        {
            id = -1;
            authCode = 0;
            name = "";
            competition = 0;
        }

        public void Auth()
        {

        }

        public void Rate(int jumpId)
        {

        }
    }
}
