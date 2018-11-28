using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModals;


namespace DataAccessLayer.Abstract
{
    public interface IUsersDatabaseService
    {
        public Add(User user);
        int Delete(User user);
        int Delete(User user);
        User Update(User user);
        User Get(int id);
        List<User> GetAll();
    }
}
