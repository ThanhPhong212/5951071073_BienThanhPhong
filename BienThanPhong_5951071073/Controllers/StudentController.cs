using BienThanPhong_5951071073.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BienThanPhong_5951071073.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var Student = new StudentInfo
                {
                    MSV = i.ToString(),
                    TenSinhVien = $"Name {i}",
                    DiaChi = $"{i}" + $"{ i + 1}" + $"{ i + 2}" + $"{ i + 3}"
                };
                StudentList.Add(Student);
            }
            return StudentList;
        }
        public StudentInfo Get(String id)
        {
            if (String.Compare(id, "5951071073", true) == 0)
            {
                return new StudentInfo
                {
                    MSV = id.ToString(),
                    TenSinhVien = "Biện Thanh Phong",
                    DiaChi = "Phú Yên"
                };

            }
            return new StudentInfo
            {
                MSV = id.ToString(),
                TenSinhVien = "Chưa có thông tin",
                DiaChi = "Chưa có thông tin"

            }; ;
        }
    }
}
