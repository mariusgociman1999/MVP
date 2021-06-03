using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class UserDA
    {
        public ObservableCollection<User> GetUsers()
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetUsers", con);
                ObservableCollection<User> result = new ObservableCollection<User>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User p = new User();
                    p.IdUser = reader.GetString(0).TrimEnd();
                    p.Parola = reader.GetString(1).TrimEnd();
                    p.IdPers = reader.GetInt32(2);
                    p.RolUs = new Rol(reader.GetInt32(3), reader.GetString(4));
                    result.Add(p);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddUser(User user)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter userId = new SqlParameter("@userID", user.IdUser);
            SqlParameter userPass = new SqlParameter("@userpass", user.Parola);
            SqlParameter rolId = new SqlParameter("@rolID", user.RolUs.IdRol);
            SqlParameter persId = new SqlParameter("@persID", user.IdPers);

            cmd.Parameters.Add(userId);
            cmd.Parameters.Add(userPass);
            cmd.Parameters.Add(rolId);
            cmd.Parameters.Add(persId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModUser(User user)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter userId = new SqlParameter("@userID", user.IdUser);
            SqlParameter userPass = new SqlParameter("@userpass", user.Parola);
            SqlParameter rolId = new SqlParameter("@rolID", user.RolUs.IdRol);
            SqlParameter persId = new SqlParameter("@persID", user.IdPers);

            cmd.Parameters.Add(userId);
            cmd.Parameters.Add(userPass);
            cmd.Parameters.Add(rolId);
            cmd.Parameters.Add(persId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
