using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web410717988.ViewModels
{
    public class SignUpData
    {
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入姓名")]
        [MinLength(5, ErrorMessage = "請輸入 5-10 個字")]
        [MaxLength(5, ErrorMessage = "請輸入 5-10 個字")]
        public string Name { get; set; }


        [Display(Name = "賬號")]
        [Required(ErrorMessage = ("請輸入賬號"))]
        [EmailAddress(ErrorMessage = "請輸入正確的Email")]
        public string Account { get; set; }


        [Display(Name = "密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [StringLength(10,MinimumLength =5,ErrorMessage = "請輸入 5-10 個字")]
        public string Password { get; set; }




        public string Message { get; set; }
    }
}