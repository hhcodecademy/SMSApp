using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.DAL.Dtos
{
    public class StudentDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }

        public string StudentNo { get; set; }
    }
}
