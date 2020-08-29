using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data
{
    using ControlTienda.Data.Entities;
    using System;
    using System.Runtime.Remoting.Contexts;
    using System.Security.Cryptography;

    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        public RolRepository(DataContext context) : base(context)
        {

        }
        public static List<Rol> AllRolTolist()
        {
            DataContext context = new DataContext();
            RolRepository repository = new RolRepository(context);
            var AllRols = repository.GetAll();
             var list = (from r in AllRols
                    select new Rol
                    {
                        Id = r.Id,
                        Name = r.Name,
                        Details = r.Details,

                    }).ToList();
            return list;

        }
        public int ObtainId(string name)
        {
            DataContext context = new DataContext();
            RolRepository repository = new RolRepository(context);
            var AllRols = repository.GetAll();
            var id = (from r in AllRols
                      where r.Name == name
                      select r.Id).FirstOrDefault();
            return id;
        }

    }
}
