using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public class Diver
    {

        public int id { get; set; }
        public int authCode { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public int competition { get; set; }

        // To track which jump to perform.
        public int jumpIndex = 0;

        public List<Jump> jumps = new List<Jump>();
        public double sumGrades { get; set; }


        public Diver()
        {

        }

        public void Auth()
        {

        }

        public void jump()
        {
            // Generate new jump and add to list.
            Jump jump = new Jump();
          
            jumps.Add(jump);
        }

        public void calcSum()
        {
            foreach (var jump in jumps)
            {
                foreach(var grade in jump.grade)
                {
                    sumGrades += grade.Item2;
                }
            }
        }
    }
}
