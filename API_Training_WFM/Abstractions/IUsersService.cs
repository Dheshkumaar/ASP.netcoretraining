using API_Training_WFM.Models;

namespace API_Training_WFM.Abstractions
{
    public interface IUsersService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Users GetByUsername(string username);
    }
}
