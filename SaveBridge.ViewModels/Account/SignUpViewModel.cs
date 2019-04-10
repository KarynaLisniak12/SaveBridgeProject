using System;

namespace SaveBridge.ViewModels.Account
{
    public class SignUpViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public Guid CityId { get; set; }

        public string Address { get; set; }
    }
}