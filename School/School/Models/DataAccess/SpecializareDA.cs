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
    class SpecializareDA
    {
        public ObservableCollection<Specializare> GetSpecializare()
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetSpecial", con);
                ObservableCollection<Specializare> result = new ObservableCollection<Specializare>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Specializare p = new Specializare();
                    p.IdSpecializare = reader.GetInt32(0);
                    p.Descriere = reader.GetString(1).TrimEnd();
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

        public void AddSpecializare(Specializare spec)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddSpecializare", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter specDesc = new SqlParameter("@desc", spec.Descriere);
           
            cmd.Parameters.Add(specDesc);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModSpecializare(Specializare spec)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModSpecializare", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter specId = new SqlParameter("@specID", spec.IdSpecializare);
            SqlParameter specDesc = new SqlParameter("@desc", spec.Descriere);

            cmd.Parameters.Add(specId);
            cmd.Parameters.Add(specDesc);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
