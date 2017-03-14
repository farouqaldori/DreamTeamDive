using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Diver_Contest
{
    [Serializable()]
    public class Diver 
    {
        public string name { get; set; }
        public string country { get; set; }
        public string gender { get; set; }
        public int competition { get; set; }
        public int id { get; set; }
        public int authCode { get; set; }
        public double sumGrades { get; set; }

        // To track which jump to perform.
        [XmlIgnore]
        public int jumpIndex = 0;

        [XmlIgnore]
        public List<Jump> jumps = new List<Jump>();

        static Random rand = new Random(220);

        public Diver()
        {
            // Generate new Authentication Code for every new Diver.
            GenerateAuthCode();
        }


        public void GenerateAuthCode()
        {
            authCode = rand.Next(100000, 999999);
        }

        public void jump()
        {
            // Generate new jump and add to list.
            Jump jump = new Jump();

            jumps[jumpIndex] = jump;
        }

        public void calcSum()
        {
            // For every jump made, get the summary of the grades
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
