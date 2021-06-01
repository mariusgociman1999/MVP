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
    class AbsentaDA
    {
        public ObservableCollection<Absenta> GetAbsenta(int elevId)
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAbsElev", con);
                ObservableCollection<Absenta> result = new ObservableCollection<Absenta>();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@elevID",elevId));

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Absenta p = new Absenta();
                    p.idAbsenta = reader.GetInt32(0);
                    p.Data = reader.GetDateTime(1);
                    p.Motivata = reader.GetBoolean(2);
                    p.Materie = new Materie(reader.GetInt32(3), reader.GetString(4));
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

        public void AddAbsenta(int elevID, Absenta absenta)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddAbsenta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter elev = new SqlParameter("@elevID", elevID);
            SqlParameter materie = new SqlParameter("@materieID", absenta.Materie.IdMaterie);
            SqlParameter motiv = new SqlParameter("@motivata", absenta.Motivata);
            SqlParameter data = new SqlParameter("@data", absenta.Data);

            cmd.Parameters.Add(elev);
            cmd.Parameters.Add(materie);
            cmd.Parameters.Add(motiv);
            cmd.Parameters.Add(data);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModAbsenta(int elevID, Absenta absenta)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModAbsenta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter absId = new SqlParameter("@absID", absenta.idAbsenta);
            SqlParameter materia = new SqlParameter("@materia", absenta.Materie.IdMaterie);
            SqlParameter elev = new SqlParameter("@elevID", elevID);
            SqlParameter motiv = new SqlParameter("@motivata", absenta.Motivata);
            SqlParameter data = new SqlParameter("@data", absenta.Data);

            cmd.Parameters.Add(absId);
            cmd.Parameters.Add(materia);
            cmd.Parameters.Add(elev);
            cmd.Parameters.Add(motiv);
            cmd.Parameters.Add(data);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
