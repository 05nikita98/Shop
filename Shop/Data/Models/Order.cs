using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длинна имени не меньше 3 символов")]
        public string name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(12)]
        [Required(ErrorMessage = "Длинна фамилии не меньше 3 символов")]
        public string surname { get; set; }
        [Display(Name = "Адресс")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длинна адресса не меньше 7 символов")]
        public string adress { get; set; }
        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(14)]
        [Required(ErrorMessage = "Длинна телефона не меньше 7 символов")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Длинна адресса не меньше 5 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        
        public List<OrderDetail> orderDetails { get; set; }
    }
}
