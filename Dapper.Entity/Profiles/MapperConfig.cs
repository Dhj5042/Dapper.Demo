using AutoMapper;
using Dapper.DataBase.Model;
using Dapper.Entity.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dapper.Entity.Profiles
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {

            CreateMap<DepartmentResponseModel, Department>().ReverseMap();
        }
    }
}
