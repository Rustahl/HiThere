using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using HiThere.Entities;
using HiThere.Interfaces;
using HiThere.Utilities;

namespace HiThere.Logic
{
    public class ApplicantDao : IApplicantDao
    {
        private Applicant _theApplicant;
        private string _path = 
            System.Reflection.Assembly.GetExecutingAssembly().Location.TrimEnd('/','H','i','T','h','e','r','e','.','e','x','e') 
            + ConfigurationManager.AppSettings["path"].ToString();
        public Applicant GetApplicant()
        { 
            var responseStream = new StreamReader(_path, Encoding.UTF8);
            _theApplicant = XmlSerializer<Applicant>.Deserialize(responseStream);
            responseStream.Close();
            responseStream.Dispose();
            return _theApplicant;
        }
    }
}
