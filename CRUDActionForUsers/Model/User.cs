using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDActionForUsers.Model
{
    public class User
    {
      
           public int   Id { get; set; }
           public string Name { get; set; }
           public DateTime BirthDate { get; set; }
            public DateTime RegistrationDate { get; set; }
            public long Mobile { get; set; }
    //  public List<Book> UserBooks { get; set; } = new List<Book>();
        
    }
}
    

