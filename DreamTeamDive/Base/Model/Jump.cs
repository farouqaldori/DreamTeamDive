using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public class Jump
    {
        // List containing a tuple with a judge object, and the grade given by the judge. Used to store multiple ratings.
        public List<Tuple<Judge, double>> grade = new List<Tuple<Judge, double>>();
        public int id { get; set; }
        public int difficulty { get; set; }

        // Status of the jump, 0 = waiting, 1 = jumped, 2 = graded.
        public int status { get; set; }
        public int style { get; set; }
        public double form { get; set; }

        // Five elements to think about when judging a compitition
        public double starting { get; set; }
        public double approach { get; set; }
        public double takeOff { get; set; }
        public double flight { get; set; }
        public double entry { get; set; }

        public Jump()
        {
            Random rnd = new Random();

            starting = rnd.Next(0, 10);
            approach = rnd.Next(0, 10);
            takeOff = rnd.Next(0, 10);
            flight = rnd.Next(0, 10);
            entry = rnd.Next(0, 10);

            form = (starting + approach + takeOff + flight + entry) * 2;

            form = rnd.Next(0, 5) + (Math.Round(form , MidpointRounding.AwayFromZero) / 10) ;
        }
    }
}
