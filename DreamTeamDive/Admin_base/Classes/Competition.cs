using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_base
{
    public class Competition
    {
        public int id { get; set; }
        public int type { get; set; }
        public string date { get; set; }

        public List<Diver> members = new List<Diver>();

        public Competition()
       {
            
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


        /// <summary>
        /// Calculate the highest rated jumper and determine the winner.
        /// </summary>
        /// <returns>Return the diver object of the winner</returns>
        public Diver end()
        {

            return members[0];
        }
    }  
}
