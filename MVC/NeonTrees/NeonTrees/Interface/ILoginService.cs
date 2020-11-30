using NeonTrees.Models;

namespace NeonTrees.Services
{
    public interface ILoginService
    {
        public void AddLogin(Login login);
        void DeleteLogin(int id);
        void EditLogin(Login login);
        public bool CheckPassward(Login login);
        public int GetNewLoginId(Login login);
        public bool CheckUserName(Login login);
        public int GetUserID(Login login);
    }
}