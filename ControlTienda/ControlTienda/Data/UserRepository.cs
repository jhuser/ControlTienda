using ControlTienda.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }
        public static List<User> UserToList()
        {
            DataContext context = new DataContext();
            UserRepository repository = new UserRepository(context);
            List<User> list = new List<User>();
            var allusers = repository.GetAll();
            var lists = (from u in allusers
                    select new User
                    {
                        Id = u.Id,
                        Name = u.Name,
                        Address = u.Address,
                        Phone = u.Phone,
                        Nickname = u.Nickname,
                        Password = u.Password,
                        Rol = u.Rol,
                    }).ToList();
            return lists;
        }
        public User user(string nick)
        {
            DataContext context = new DataContext();
            User user = new User();
            return user = (from u in context.users
                    where u.Nickname == nick
                    select u).FirstOrDefault();

        }
    }
}
