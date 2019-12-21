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
        public UserBusiness()
        {
            this.usersRepository = new UsersRepository();
        }
        public List<User> GetAllUsers()
        {
            return this.usersRepository.GetAllUsers();
        }
        public string InsertUser(User user)
        {
            if (usersRepository.InsertUser(user) != 0)
                return "User successfully inserted into the database!";
            else
                return "User was not inserted into the database!";
        }
        public string DeleteUser(User user)
        {
            if (usersRepository.DeleteUser(user.Id) != 0)
                return "User successfully deleted!";
            else
                return "User was not deleted!";
        }
        public string UpdateUser(User user)
        {
            if (usersRepository.UpdateUser(user) != 0)
                return "User successfully updated!";
            else
                return "User was not updated!";
        }
    }
}
