using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDActionForUsers.Service
{
    public class Validations
    {
        public bool mobileValidation(int mobile)
        {
            if (mobile.ToString().Length > 11 || mobile.ToString().Length <= 10)
            {
                return false;
            }
            else return true;
        }
        public bool dateValidation(DateTime date)
        {
            if (DateTime.Compare(date,DateTime.Now) >0)
            {
                return false;
            }
            else return true;
        }

    }
}
