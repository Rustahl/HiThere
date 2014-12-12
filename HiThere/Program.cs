using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiThere.Logic;

namespace HiThere
{
    /// <summary>
    /// So here is a quick dirty example of a console application I threw together for a requested C# example.
    /// It should work, Its pretty ugly but I wanted to get something to you sooner than later. Enjoy!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PrintApplicantInformation();
            Console.Read();
            
        }
        public static void PrintApplicantInformation()
        {
            ApplicantWriter writer = new ApplicantWriter(new ApplicantDao());
            writer.PrintApplicant();
        }
    }
}
