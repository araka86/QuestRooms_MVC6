﻿using System.ComponentModel.DataAnnotations;
namespace QuestRooms6.Model.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; } = string.Empty;
    }
}