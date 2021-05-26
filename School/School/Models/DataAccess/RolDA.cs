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
    class RolDA
    {
        public ObservableCollection<Rol> GetRol()
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetRol", con);
                ObservableCollection<Rol> result = new ObservableCollection<Rol>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Rol p = new Rol();
                    p.IdRol = reader.GetInt32(0);
                    p.Descriere = reader.GetString(1);
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

        public void AddRol(Rol rol)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddRoluri", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter rolDesc = new SqlParameter("@desc", rol.Descriere);

            cmd.Parameters.Add(rolDesc);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModRol(Rol rol)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModRol", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter rolId = new SqlParameter("@rolID", rol.IdRol);
            SqlParameter rolDesc = new SqlParameter("@desc", rol.Descriere);

            cmd.Parameters.Add(rolId);
            cmd.Parameters.Add(rolDesc);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
