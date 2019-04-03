namespace Repository
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    [Table("UserInfo")]
    public partial class UserInfo
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string EmailAddress { get; set; }

        [StringLength(30)]
        public string Password { get; set; }

        [StringLength(5)]
        public string IsStudent { get; set; }
    }
}
