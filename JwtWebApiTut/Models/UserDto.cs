namespace JwtWebApiTut.Models
{
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; }= string.Empty;//we may need a confrim password property

    }
}
