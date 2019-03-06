using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KSC.Models
{
    public class AccountViewModel
    {

        public int ID { get; set; }

        [Display(Name = "姓名")]
        [StringLength(64), Required(ErrorMessage = "請輸入姓名")]
        public string Name { set; get; }

        [Display(Name = "帳號")]
        [StringLength(128), Required(ErrorMessage = "請輸入帳號")]
        public string Account { set; get; }

        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        //[RegularExpression(@"^.*(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*\(\)_\-+=]).*$", ErrorMessage = "密碼至少需要1個文字及1個數字")]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "請輸入至少6位數的密碼"), Required(ErrorMessage = "請輸入密碼")]
        public string Password { set; get; }


        [Display(Name = "確認密碼")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "確認密碼不符合，請重新輸入")]
        public string PasswordConfirm { set; get; }

        [Display(Name = "權限")]
        public string Status { set; get; }

        [Display(Name = "地址")]
        [StringLength(128), Required(ErrorMessage = "請輸入地址")]
        public string Address { set; get; }

        [Display(Name = "Email")]
        [StringLength(128), Required(ErrorMessage = "請輸入信箱")]
        public string Email { set; get; }

        [Display(Name = "上工日期")]
        [DataType(DataType.Date, ErrorMessage = "請選擇上工日期")]
        public DateTime OnBoardTime { set; get; }

    }
}