using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.Authentication
{
	public class LoginModel
	{
		[Required]
		public string Username { get; set; }

		[Required]
		public string Password { get; set; }
	}
}