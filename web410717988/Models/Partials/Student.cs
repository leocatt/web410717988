﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web410717988.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }

    public class StudentMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "請填寫姓名")]
        [Display(Name = "姓名")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "請輸入 5-10 個字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "請輸入 5-10 個字")]
        public string Number { get; set; }

        [Required(ErrorMessage = "請填寫Email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "請輸入正確的Email")]
        public string Email { get; set; }

    }
}