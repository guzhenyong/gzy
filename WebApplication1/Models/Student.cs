using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models

{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [StringLength (300,MinimumLength = 1)]

        public string? Name { get; set; }
        [Display(Name = "性别")]
        [StringLength(1)]

        public String? Gender { get; set; }
        [Display(Name = "年龄")]
        [Range(1, 200)]

        public int Age { get; set; }
        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]

        public DateTime Birthday { get; set; }
        [Display(Name = "手机号")]
        [StringLength(13)]

        public String Phone { get; set; }

        [Display(Name = "体温")]
        [Range(30, 50)]

        public String Temperature { get; set; }

        [Display(Name = "填表日期")]
        [DataType(DataType.Date)]

        public DateTime Outtimes { get; set; }

    }
}
