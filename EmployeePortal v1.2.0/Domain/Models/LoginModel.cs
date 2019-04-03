using Domain.Interfaces;


namespace Domain.Models
{
    class LoginModel:IUserLogin
    {
        public string EmailAddress { get; set; }
        public string Password { get; set;}
    }
}
