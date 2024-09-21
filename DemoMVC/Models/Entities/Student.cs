using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models.Entities
{
    public class Student
    {
        //chỉ định tên của table
       // [Table("SinhVien")]
        public string StudentID { get; set; }   
        public string Fullname { get; set;}
        public string Address { get; set;}
    }
}