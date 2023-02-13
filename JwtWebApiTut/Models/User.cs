namespace JwtWebApiTut.Models
{
    public class User
    {
        public string Username { get; set; } = String.Empty; //may need an id to store the username in the data base
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
