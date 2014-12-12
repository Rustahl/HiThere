using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiThere.Interfaces;

namespace HiThere.Logic
{
    public class ApplicantWriter
    {
        IApplicantDao _applicantDao;

        public ApplicantWriter(IApplicantDao Dao)
        {
            this._applicantDao = Dao;
        }

        public void PrintApplicant()
        {
            var data = _applicantDao;
            var lineBreak = "\n";
            var applicant = data.GetApplicant();
            Console.WriteLine(
                string.Format(
                "Hello my name is {0} {1}{5}{5}I thank you for your consideration for this position with {4}.{5}{5}My email address is {2}.{5}{5}Additionally, I can be reached by phone at {3}.{5}{5}Have a great day!"
                ,applicant.FirstName
                ,applicant.LastName
                ,applicant.Email
                ,applicant.Phone,
                applicant.CompanyApplyingFor,
                lineBreak));
        }
    }
}
