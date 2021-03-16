using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace BienThanPhong_5951071073.Models
{
    public class StudentInfo
    {
        [DataMember(Name = "MSV")]
        public String MSV { get; set; }
        [DataMember(Name = "Ten Sinh vien")]
        public String TenSinhVien { get; set; }
        [DataMember(Name = "Dia Chi")]
        public String DiaChi { get; set; }
    }
}