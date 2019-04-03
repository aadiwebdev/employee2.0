using Domain.Interfaces;

namespace Business.Factory
{
    public interface IAuthenticationBusiness
    {
         string ValidateLogin(IModel loginModel);
        string RegisterUser(IModel registrationModel);
    }
}
        
