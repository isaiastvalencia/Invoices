
using System;
using DEMO09.BusinessInterfaces;
using DEMO09.DataInterfaces;
using DEMO09.Types;


namespace DEMO09.BusinessLayer
{
    public class UserProcessor : IUserProcessor
    {
        private readonly IUserRepository _UserRepository;

        public UserProcessor(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public void ForgotPassword(UserForgotPassword entitie)
        {
            //nota: Para este caso resultaria talvez mas util que regresara un booleano ó
            //que regrese todo el item del usuario, y ocupemos el campo que necesitemos.
            if(_UserRepository.FindUserByEmail(entitie.Email)=="" )
            {
                throw new Exception("El usuario no es valido");
            }
            
            //FALTA: Enviar el password que se encontro al correo que proporciono el usuario o una pagina para generarlo de nuevo.
        }

        public void SignIn(UserSignIn entitie)
        {
            if (!_UserRepository.FindUserByEmailAndPassword(entitie) )
            {
                throw new Exception("No existe el nombre de usuario o la constraseña es incorrecta");
            }

            //if(entitie.Email!=string.Empty && entitie.Password!=String.Empty)
            //{
            //    UserRepository repo = new UserRepository();
            //    return repo.FindUserByEmailAndPassword(entitie);
            //}
        }

        public void SignUp(UserSignUp entitie)
        {
            if (_UserRepository.IsEmailRegistered(entitie.Email))
            {
                throw new Exception("Este email ya se encuentra registrado");
            }
            
            _UserRepository.AddUser(entitie);
        }
    }
}
