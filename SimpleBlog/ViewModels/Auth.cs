using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password),Required]
        public string Password { get; set; }
    }
}