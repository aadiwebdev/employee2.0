using Domain.Enums;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Data;


namespace Repository.Factory
{
    public interface IUserRepo
    {
        List<IModel> GetUserDetails(UserRoleChoice userRoleChoice);
    }
}
       