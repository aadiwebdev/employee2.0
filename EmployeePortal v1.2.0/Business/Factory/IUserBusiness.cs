using Domain.Enums;
using Domain.Interfaces;
using System.Collections.Generic;


namespace Business.Factory
{
    public interface IUserBusiness
    {
        List<IModel> GetUserDetails(UserRoleChoice userRoleChoice);
    }
}
