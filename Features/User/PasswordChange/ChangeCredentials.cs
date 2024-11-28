﻿namespace Coffee_Ecommerce.API.Features.User.PasswordChange
{
    public sealed class ChangeCredentials
    {
        public string Email { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}
