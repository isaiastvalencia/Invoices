
using DEMO09.Types;

namespace DEMO09.BusinessInterfaces
{
    public interface IUserProcessor
    {
        void SignIn(UserSignIn entitie);
        void SignUp(UserSignUp entitie);
        void ForgotPassword(UserForgotPassword entitie);
    }
}

