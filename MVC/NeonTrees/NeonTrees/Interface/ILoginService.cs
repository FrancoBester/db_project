using NeonTrees.Models;

namespace NeonTrees.Services
{
    public interface ILoginService
    {
        public void AddLogin(Login login);
        void DeleteLogin(Login login);
        void EditLogin(Login login);
        public bool GetLoginByUser(Login login);
        public int GetNewLoginId(Login login);
    }
}