
using DEMO09.Types;

namespace DEMO09.DataInterfaces
{
    public interface IUserRepository
    {
        int AddUser(UserSignUp entitie);
        bool FindUserByEmailAndPassword(UserSignIn entitie);
        string FindUserByEmail(string Email);
        bool IsEmailRegistered(string Email);
    }
}
