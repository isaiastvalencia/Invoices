using DEMO09.DataInterfaces;
using DEMO09.DataLayerMSSQLWithEF;
using DEMO09.Types;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Crear una cuenta de usuario
            //UserRepository repo = new UserRepository();
            //UserSignUp item = new UserSignUp();
            //item.Name = "Isaias";
            //item.Email = "isaias.torres@algo.com";
            //item.Password = "Ab12345";
            //item.CreationDate = DateTime.Now;
            //var result = repo.AddUser(item);

            ////Buscar un usuario y password
            //UserRepository rep = new UserRepository();
            //UserSignIn entitie = new UserSignIn();
            //entitie.Email = "isaias.torres@algo.com";
            //entitie.Password = "Ab12345";
            //if (rep.FindUserByEmailAndPassword(entitie))
            //    Console.Write("Si lo encontro");
            //else
            //    Console.Write("No lo encontro");


            ////Buscar email y retornar password para enviar por correo.
            //UserRepository repo = new UserRepository();
            //string email = "isaias.torres@algo.com";
            //var result = repo.FindUserByEmail(email);
            //Console.WriteLine($"El usuario con email {email}, su password es {result}");


            ////Validar si el correo ya se encuentra o no registrado, sino crear la cuenta.
            //IUserRepository irepo;
            //UserRepository repo = new UserRepository();
            //irepo = repo;
            //UserSignUp item = new UserSignUp();
            //item.Name = "Isaias";
            //item.Email = "isaias.torres@email.com";
            //item.Password = "Ab12345";
            //item.CreationDate = DateTime.Now;
            //if (irepo.IsEmailRegistered(item.Email))
            //{
            //    Console.WriteLine($"El Email {item.Email} ya esta registrado");
            //}
            //else
            //{
            //    Console.WriteLine("La cuenta se creó satisfactoriamente");
            //}


            Console.ReadKey();
        }
    }
}
