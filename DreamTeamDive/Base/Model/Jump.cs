using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public class Jump
    {
        public int id { get; set; }
        public int difficulty { get; set; }
        // List containing a tuple with a judge object, and the grade given by the judge. Used to store multiple ratings.
        public List<Tuple<Judge, double>> grade = new List<Tuple<Judge, double>>();
        // Status of the jump, 0 = waiting, 1 = jumped, 2 = graded.
        public int status { get; set; }
        public int style { get; set; }
        public double form { get; set; }
        public double takeOff { get; set; }
        public double finishing { get; set; }
        public Jump()
        {
            Random rnd = new Random();

            takeOff = rnd.Next(0, 10);
            finishing = rnd.Next(0, 10);

            form = (takeOff + finishing) * 2;

            form = rnd.Next(0, 5) + (Math.Round(form , MidpointRounding.AwayFromZero) / 4) ;
        }
    }
}
