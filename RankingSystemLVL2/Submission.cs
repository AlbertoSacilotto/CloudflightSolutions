using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RankingSystem
{
    public class Submission
    {
        public int ID { get; set; }
        public DateTime Sub { get; set; }
        public bool Correct { get; set; }

        public Submission(int id, DateTime sub, bool correct)
        {
            ID = id;
            Sub = sub;
            Correct = correct;
        }

    }
}
