using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp.Models
{
    public class Triangle
    {
        [Required(ErrorMessage = "Введите число")]
        [RegularExpression(@"\d+", ErrorMessage = "Вы ввели некорректные данные")]
        public double A { get; set; } //катет A

        [Required(ErrorMessage = "Введите число")]
        [RegularExpression(@"\d+", ErrorMessage = "Вы ввели некорректные данные")]
        public double B { get; set; } //катет B

        [Required(ErrorMessage = "Введите число")]
        [RegularExpression(@"\d+", ErrorMessage = "Вы ввели некорректные данные")]
        public double C { get; set; } //гипотенуза C
    }
}
