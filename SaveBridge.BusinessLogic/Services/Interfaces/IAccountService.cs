using System.Threading.Tasks;
using SaveBridge.ViewModels.Account;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IAccountService
    {
        Task<bool> IsRegistered(SignInViewModel model);

        Task<bool> SignUp(SignUpViewModel model);
    }
}