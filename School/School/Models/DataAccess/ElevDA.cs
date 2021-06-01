using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class ElevDA
    {
        public Elev GetElev(int persID)
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetElevData", con);
                Elev result = new Elev();

                SqlParameter persId = new SqlParameter("@persID", persID);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(persId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result.IdPers = reader.GetInt32(0);
                    result.Nume = reader.GetString(1);
                    result.Prenume = reader.GetString(2);
                    result.IdElev = reader.GetInt32(3);
                    result.ClasaFrecv = new Clasa(reader.GetInt32(4), reader.GetString(5), new Specializare(reader.GetInt32(6), reader.GetString(7)));
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
        public void AddElev(Elev elev)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddElev", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter elevNume = new SqlParameter("@nume", elev.Nume);
            SqlParameter elevPrenume = new SqlParameter("@prenume", elev.Prenume);
            SqlParameter clasaElev = new SqlParameter("@clasa", elev.ClasaFrecv.IdClasa);

            cmd.Parameters.Add(elevNume);
            cmd.Parameters.Add(elevPrenume);
            cmd.Parameters.Add(clasaElev);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModElev(Elev elev)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModElev", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter persId = new SqlParameter("@persID", elev.IdPers);
            SqlParameter elevId = new SqlParameter("@elevID", elev.IdElev);
            SqlParameter elevNume = new SqlParameter("@nume", elev.Nume);
            SqlParameter elevPrenume = new SqlParameter("@prenume", elev.Prenume);
            SqlParameter clasaElev = new SqlParameter("@clasa", elev.ClasaFrecv.IdClasa);

            cmd.Parameters.Add(elevId);
            cmd.Parameters.Add(elevNume);
            cmd.Parameters.Add(elevPrenume);
            cmd.Parameters.Add(persId);
            cmd.Parameters.Add(clasaElev);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
