﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NhaKhoa.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    //public class EmailOrUserName
    //{
    //    [Required]
    //    [Display(Name = "Email")]
    //    public string Email { get; set; }

    //    [Required]
    //    [Display(Name = "Username")]
    //    public string UserName { get; set; }
    //}

    public class LoginViewModel
    {
        [Required]
        public string EmailOrUserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Required]
        //[EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        //[EmailAddress]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "DiaChi")]
        public string DiaChi { get; set; }
        [Required]
        [Display(Name = "NgheNghiep")]
        public string NgheNghiep { get; set; }
        [Required]
        [Display(Name = "CCCD")]
        public string CCCD { get; set; }
        [Required]
        [Display(Name = "GioiTinh")]
        public bool GioiTinh { get; set; }
        [Required]
        [Display(Name = "NgaySinh")]
        public DateTime NgaySinh { get; set; }
        [Required]
        [Display(Name = "NgayTao")]
        public DateTime NgayTao { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        //[EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
