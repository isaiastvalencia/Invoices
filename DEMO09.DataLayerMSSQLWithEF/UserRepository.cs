
using System;
using DEMO09.DataInterfaces;
using DEMO09.Types;
using System.Configuration;
using System.Linq;

namespace DEMO09.DataLayerMSSQLWithEF
{
    public class UserRepository : IUserRepository
    {
        private readonly string connString;

        public UserRepository()
        {
            connString = ConfigurationManager.ConnectionStrings["AgileInvoice"].ConnectionString;
        }

        public int AddUser(UserSignUp entitie)
        {
            int result = 0;
            using (var context = new AgileInvoiceDbContext(connString))
            {
                User item = new User();
                item.Name = entitie.Name;
                item.Email = entitie.Email;
                item.Password = entitie.Password;
                item.CreationDate = DateTime.Now;

                context.Users.Add(item);
                result = context.SaveChanges();
            }
            return result;
        }

        public string FindUserByEmail(string Email)
        {
            string password="";

            IQueryable<User> lista = null;
            using (var context = new AgileInvoiceDbContext(connString))
            {
                lista = from item in context.Users
                       where item.Email == Email
                       select item;

                if (lista.Count() > 0)
                {
                    password = lista.FirstOrDefault().Password;
                }
            }

            //IQueryable algo = null;
            //using (var context = new AgileInvoiceDbContext(connString))
            //{
            //     algo = context.Users
            //                .Where(w => w.Email == Email)
            //                .Select(s => s.Password);

            //}

            return password;
        }

        public bool FindUserByEmailAndPassword(UserSignIn entitie)
        {
            bool result = false;

            IQueryable<User> lista = null;
            using (var context = new AgileInvoiceDbContext(connString))
            {
                //result = context.Users.Select(item => item.Email == entitie.Email && item.Password == entitie.Password).FirstOrDefault(); //dejo de funcionar!!!
                lista = from item in context.Users
                            where item.Email == entitie.Email && item.Password == entitie.Password
                            select item;
                if (lista.Count() > 0)
                    result = true;
            }
            return result;
        }

        public bool IsEmailRegistered(string Email)
        {
            bool result = false;
            using (var context = new AgileInvoiceDbContext(connString))
            {
                //result = context.Users.Select(item => item.Email == Email).FirstOrDefault();
                IQueryable<User> lista = from row in context.Users
                                         where row.Email == Email
                                         select row;
                if (lista.Count() > 0)
                    return true;
            }
            return result;
        }
    }
}
