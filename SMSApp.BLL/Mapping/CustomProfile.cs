using AutoMapper;
using SMSApp.DAL.Dtos;
using SMSApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.BLL.Mapping
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<Student,StudentDto>().ReverseMap();
        }
    }
}
