using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KSC.Models
{
    public class LoginViewModel
    {
        [Display(Name = "帳號")]
        [StringLength(128), Required(ErrorMessage = "請輸入帳號")]
        public string UserName { set; get; }

        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "請輸入密碼")]
        public string Password { set; get; }

    }
}