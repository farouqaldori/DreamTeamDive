using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public class Judge
    {

        public int id { get; set; }
        public int authCode { get; set; }
        public string name { get; set; }
        public int competition { get; set; }

        public Judge()
        {
        }

        public void Auth()
        {
        }

        public void rate(Jump _jump, double _grade)
        {
            // By using the ID, we can modify the database.

            // Grade jump by creating a new tuple with the judge and the grade given.
            var rating = Tuple.Create(this, _grade);
            _jump.grade.Add(rating);
        }

    }
}
