using NeonTrees.Models;

namespace NeonTrees.Services
{
    public interface ILoginService
    {
        void AddLogin(Login login);
        void DeleteLogin(Login login);
        void EditLogin(Login login);
        public bool GetLoginByUser(Login login);
    }
}