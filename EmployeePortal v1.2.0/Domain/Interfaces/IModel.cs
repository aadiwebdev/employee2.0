using Domain.Models;


namespace Domain.Interfaces
{
    public interface IModel: GenericMapper<UserModel>,IRegisterUser,IUserLogin
    {
    }
}
