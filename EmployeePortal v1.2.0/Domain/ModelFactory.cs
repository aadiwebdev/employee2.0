

using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;

namespace Domain
{
    public class ModelFactory
    {
        /// <summary>
        /// It is used to return appropriate object at runtime as per the requirement of the user/client
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        public static  IModel GetModel(ModelSelection modelType)
        {
            IModel model = null;
          if (modelType.Equals(ModelSelection.Login))
            {
                model = (IModel)new LoginModel();
            }
            else if (modelType.Equals(ModelSelection.Register))
            {
                model = (IModel)new RegistrationModel();
            }
            else if (modelType.Equals(ModelSelection.User))
            {
                model = (IModel)new UserModel();
            }
            return model;
        }
    }
}