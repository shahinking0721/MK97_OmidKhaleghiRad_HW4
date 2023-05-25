using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDActionForUsers;
using CRUDActionForUsers.Model;
using static System.Net.Mime.MediaTypeNames;

namespace CRUDActionForUsers.DB
{
    internal class Storage
    {
        // public static List<Users> users = new List<Users>() {
        string textFile = @"C:\Users\shahi\source\repos\CRUDActionForUsers\CRUDActionForUsers\FileDataStorage.csv";
        // new Users(){Id=1, Name ="omid" ,Mobile=09196097210,BirthDate=DateTime.Now,RegistrationDate=DateTime.Now }  };
        public bool AddUser(User user)
        {
           
         
            string  alltext= user.Id + "," + user.Name + "," + user.Mobile + "," + user.BirthDate + "," + user.RegistrationDate + ",,";
            string[] all= { alltext };
         
            File.AppendAllLines(textFile, all);
            return true;
        }

        internal bool DeleteUser(int id)
        {
            // FileStream fileStream = new FileStream(@"./DB/FileDataStorage.csv", FileMode.Create);
            string text = File.ReadAllText(textFile);
            int i = 0;
            foreach (var item in text)
            {
                if (item.ToString() != ",") i++;
                else  break;

            }
           string aaa=  text.Remove(60,i);
            File.WriteAllText(textFile, aaa);
            return true;

        }
       public bool Update(String value, string repValue)
        {
            string text = File.ReadAllText(textFile);
            File.WriteAllText(textFile, text.Replace(value, repValue));
              
            return true;    
        }

        public string[] getAll()
        {
          string[] text = File.ReadAllLines(textFile);
            return text;
        }

    }
}


/*  int j = 0;
            foreach (string line in readText)
            {
                string one = readText[j];
                int lent = one.Length;
                string[] strarry = new string[lent];
                int i = 0;
                string m = "";
                int lines = 0;
                foreach (var item in one)
                {
                    
                        string s = Convert.ToString(item);
                        m = m + s;
                    

                    
                        if (m == Convert.ToString(id)) goto omid;

                        strarry[i] = m;
                        
                        i++;
                        m = "";
                    
                }
                lines++;
                omid: j++;
                
                File.WriteAllLines(textFile,strarry);

            }*/