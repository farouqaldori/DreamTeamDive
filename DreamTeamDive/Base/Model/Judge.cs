using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Diver_Contest
{
    [Serializable()]
    public class Judge
    {
        public string name { get; set; }
        public int competition { get; set; }
        public int id { get; set; }
        public int authCode { get; set; }
        
        static Random rand = new Random(120);

        public Judge()
        {   
            // Generate new Authentication Code for every new Judge.
            GenerateAuthCode();
        }

      
        public void GenerateAuthCode()
        {
            authCode = rand.Next(100000, 999999);
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
