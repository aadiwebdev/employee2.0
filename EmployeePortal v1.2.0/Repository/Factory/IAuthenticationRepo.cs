using Domain.Interfaces;

namespace Repository.Factory
{
    public interface IAuthenticationRepo
    {
        string ValidateLogin(IModel loginModel);
         string RegisterUser(IModel registrationModel);
        bool IsAlreadyRegistered(IModel registrationModel);
    }
}




