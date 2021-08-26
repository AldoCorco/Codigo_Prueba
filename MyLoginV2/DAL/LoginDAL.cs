using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Domain;

namespace DAL
{
    public class LoginDAL
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_Login(Domain.LoginDomain objD)
        {
            SqlCommand cmd = new SqlCommand("sp_login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", objD.usu1);
            cmd.Parameters.AddWithValue("@pas", objD.pass1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dtable1 = new DataTable();
            da.Fill(dtable1);
            return dtable1;
        }
    }
}
