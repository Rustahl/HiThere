using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiThere.Entities;
namespace HiThere.Interfaces
{
    public interface IApplicantDao
    {
        Applicant GetApplicant();
    }
}
