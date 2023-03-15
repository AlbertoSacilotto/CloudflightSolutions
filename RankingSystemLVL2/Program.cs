using RankingSystem;
using System;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string filePath = "input.txt"; //put input file in bin archive
            string fileContent = File.ReadAllText(filePath);
            string[] lines = fileContent.Split(' ');
            DateTime start = DateTime.Parse(lines[0]);
            //int totalSub = Int32.Parse(lines[1]);  total inputs not needed 
            List<Submission> list = new List<Submission>();
            for (int i = 2; i < lines.Length; i+=3)
            {
                if (lines[i + 2] == "correct")
                {
                    list.Add(new Submission(Int32.Parse(lines[i]), DateTime.Parse(lines[i+1]), true));
                }
            }
            Submission res = FastestSub(list, start);
            Console.WriteLine($"{res.ID} {res.Sub}");
        }
        static Submission FastestSub(List<Submission> list, DateTime start)
        {
            Submission rtn = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if ((int)(list[i].Sub - start).TotalSeconds < (int)(rtn.Sub - start).TotalSeconds)
                {
                    rtn = list[i];
                }
            }
            return rtn;
        }
    }
}