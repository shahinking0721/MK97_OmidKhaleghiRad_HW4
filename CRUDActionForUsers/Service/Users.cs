using CRUDActionForUsers.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDActionForUsers;
using CRUDActionForUsers.Model;

namespace CRUDActionForUsers.Service
{
    public class Users : IUsers
    {
        public bool Create(User user)
        {
            Storage storage=new Storage();
            bool result = storage.AddUser(user);
            if (result == true) return true;else return false;
        }

        public bool Delete(int id)
        {
            Storage storage = new Storage();
            bool result = storage.DeleteUser(id);
            return result;
        }

        public string[] GetAll()
        {
            Storage storage = new Storage();
            string[] result= storage.getAll();
            return result;
        }

        public bool Update(string value,string repValue)
        {
            Storage storage = new Storage();
            bool result = storage.Update(value,repValue) ;
            return result;
        }
    }
}
