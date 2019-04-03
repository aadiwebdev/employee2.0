

namespace Repository.Interfaces
{
    public interface IModel
    {
         string EmailAddress { get; set; }
         string Password { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
         string ConfirmPassword { get; set; }
         string IsStudent { get; set; }
    }
}
