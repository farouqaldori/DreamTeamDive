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

        public double max { get; set; } = 0.0;
        public double min { get; set; } = 10.0;
        public double result { get; set; }  = 0.0;
        public double Difficulty { get; set; }

        public int id { get; set; }
        public int authCode { get; set; }
        public double sumGrades { get; set; }

        // To track which jump to perform.
        [XmlIgnore]
        public int jumpIndex = 0;

        [XmlIgnore]
        public List<Jump> jumps = new List<Jump>();

        static Random rand = new Random(220);


        //public Diver()
        //{

        //}

        //public void Auth()
        //{

        //}

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

        public double calcSum(int diffu)
        {
            // For every jump made, get the sum of the grades
            foreach (var jump in jumps)
           {
                foreach (var grade in jump.grade)
                {
                    sumGrades += grade.Item2;
                    if (grade.Item2 < min)
                    {
                        min = grade.Item2;
                    }
                    if (grade.Item2 > max)
                    {
                        max = grade.Item2;
                    }
                   
                }
                result=((sumGrades-min-max)/5)*3*diffu; //efter 3, 3*difficulty;
            }
           
            return result; 
        }
    }
}
