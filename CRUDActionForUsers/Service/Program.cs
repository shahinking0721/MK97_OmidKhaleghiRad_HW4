using CRUDActionForUsers.Model;
using CRUDActionForUsers.Service;
using CRUDActionForUsers.DB;


User user = new User();
Users users = new Users();  
Console.WriteLine("see all users peress (1)");
Console.WriteLine("add users peress (2)");
Console.WriteLine("update users peress (3)");
Console.WriteLine("delete  user peress (4)");
string result=Console.ReadLine();
switch (result)
{
    case "1":
        string[] result1 = users.GetAll();
        foreach (var item in result1)
        {
            Console.WriteLine(item);
        }
        break;
    case "2":
        
        user.Id = 11;
        user.Name = "Test2";
        user.BirthDate = DateTime.Now;
        user.RegistrationDate = DateTime.Now;
        user.Mobile = 09196065210;

        bool result2 = users.Create(user);
        break;
    case "3": bool result3 = users.Update("test","example");
       
        break;
    case "4":  bool result4 = users.Delete(2);
     
        break;
    
}

 
   
  

