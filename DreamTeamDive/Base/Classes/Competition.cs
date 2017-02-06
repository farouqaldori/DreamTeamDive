using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public class Competition
    {
        public int id { get; set; }
        public int type { get; set; }
        public string date { get; set; }

        public List<Diver> divers = new List<Diver>();

        public List<Judge> judges = new List<Judge>();
        public Competition()
        {
            
        }

        public void generate()
        {

        }

        public void addDiver(Diver diver)
        {
            //Add Diver
            divers.Add(diver);
        }

        public void addJudge(Judge judge)
        {
            //Add Judge
           judges.Add(judge);
        }

        public void start()
        {

        }


        /// <summary>
        /// Calculate the highest rated jumper and determine the winner.
        /// </summary>
        /// <returns>Return the diver object of the winner</returns>
        public double end()
        {
            double max = double.MinValue;
            foreach(var _divers in divers)
            {
                if(_divers.sumGrades > max)
                {
                    max = _divers.sumGrades;
                }
            }
            return max;
        }
    }  
}
