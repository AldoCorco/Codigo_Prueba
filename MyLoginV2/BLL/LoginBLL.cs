using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class LoginBLL
    {
       /// <summary>
       /// 
       /// </summary>
        
        DAL.LoginDAL objd = new DAL.LoginDAL();

        public DataTable N_Login(Domain.LoginDomain objD)
        {
            return objd.D_Login(objD);
        }
    }
}
