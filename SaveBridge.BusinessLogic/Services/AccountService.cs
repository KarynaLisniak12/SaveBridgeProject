using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.Account;
using System.Threading.Tasks;

namespace SaveBridge.BusinessLogic.Services
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountService(IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<bool> IsRegistered(SignInViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return false;
            }

            var isCorrectPassword = await _userManager.CheckPasswordAsync(user, model.Password);
            return isCorrectPassword;
        }

        public async Task<bool> SignUp(SignUpViewModel model)
        {
            ApplicationUser user = _mapper.Map<SignUpViewModel, ApplicationUser>(model);
            user.CityId = null;

            var registeredUser = await _userManager.FindByEmailAsync(model.Email);
            if (registeredUser != null)
            {
                return false;
            }

            var result = await _userManager.CreateAsync(user, model.Password);
            return result.Succeeded;
        }
    }
}