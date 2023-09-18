using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.DAL.Models
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
