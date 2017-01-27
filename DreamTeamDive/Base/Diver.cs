using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Diver
    {

        public int id { get; set; }
        int authCode { get; set; }
        string name { get; set; }
        string country { get; set; }
        int competition { get; set; }


        public Diver()
        {
            id = -1;
            authCode = 0;
            name = "";
            country = "";
            competition = 0;
        }

        public void Auth()
        {

        }

        public void jump()
        {

        }
    }
}
