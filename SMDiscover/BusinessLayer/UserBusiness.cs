using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusiness
    {
	private UsersRepository usersRepository;
        public UsersBusiness()
        {
            this.usersRepository = new UsersRepository();
        }
        public List<Users> GetAllUsers()
        {
            return this.usersRepository.GetAllUsersFromDB();
        }
    }
}
