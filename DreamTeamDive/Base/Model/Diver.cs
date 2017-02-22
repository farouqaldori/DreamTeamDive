using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Diver_Contest
{
    [Serializable()]
    public class Diver /*: IComparable<Diver>*/
    {
        public string name { get; set; }
        public string country { get; set; }
        public int competition { get; set; }
        public int id { get; set; }
        public int authCode { get; set; }

        // To track which jump to perform.
        [XmlIgnore]
        public int jumpIndex = 0;
        [XmlIgnore]
        public double sumGrades { get; set; }

        [XmlIgnore]
        public List<Jump> jumps = new List<Jump>();
       


        public Diver()
        {

        }


        public void Auth()
        {

        }

        //public int CompareTo(Diver obj)
        //{
        //    int c = this.name.CompareTo(obj.name);
        //    if (c == 0)
        //        return this.sumGrades.CompareTo(obj.sumGrades);
        //    else
        //        return c;
        //}

        public void jump()
        {
            // Generate new jump and add to list.
            Jump jump = new Jump();
          
            jumps.Add(jump);
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
