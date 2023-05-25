using CRUDActionForUsers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDActionForUsers.Service
{
    public interface IUsers
    {
        public bool Create(User users);
        public bool Update(string value, string repValue);    
        public bool Delete(int id);
        string[] GetAll();   

       
            
      
    }
}
