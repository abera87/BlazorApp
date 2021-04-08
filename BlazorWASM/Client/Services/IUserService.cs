using BlazorWASM.Shared.Model;

namespace BlazorWASM.Client.Services
{
    public interface IUserService
    {
        string UserEmail { get; }

        bool Login(LoginModel loginModel);
    }
}