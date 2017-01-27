using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_base
{
    class Competition
    {
        public int id { get; set; }
        public int type { get; set; }
        public int date { get; set; }
        public int[] number { get; set; }
        
       public Competition()
       {
            id = -1;
            type = 0;
            date = 0;
       }

        public void generate()
        {

        }

        public void addDiver()
        {

        }

        public void addJudge()
        {

        }

        public void start()
        {

        }
    }

    

    
}
