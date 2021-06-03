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
    class MaterieDA
    {
        public ObservableCollection<Materie> GetMaterie()
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetMaterii", con);
                ObservableCollection<Materie> result = new ObservableCollection<Materie>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Materie p = new Materie();
                    p.IdMaterie = reader.GetInt32(0);
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

        public void AddMaterie(Materie materie)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddMaterie", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter matDesc = new SqlParameter("@desc", materie.Descriere);

            cmd.Parameters.Add(matDesc);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModMaterie(Materie materie)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModMaterie", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter matId = new SqlParameter("@materieID", materie.IdMaterie);
            SqlParameter matDesc = new SqlParameter("@desc", materie.Descriere);

            cmd.Parameters.Add(matId);
            cmd.Parameters.Add(matDesc);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
