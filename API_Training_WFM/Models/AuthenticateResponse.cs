namespace API_Training_WFM.Models
{
    public class AuthenticateResponse
    {
        public string Username { get; set; }
        public string name { get; set; }
        public string Token { get; set; }

        public string role { get; set; }

        public AuthenticateResponse(Users users, string token)
        {
            Username = users.username;
            name = users.name;
            role = users.role;
            Token = token;
        }
    }
}
