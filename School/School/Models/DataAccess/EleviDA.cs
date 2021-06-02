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
    class EleviDA
    {
        public ObservableCollection<Elev> GetEleviClasa(int clasaID)
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetEleviClasa", con);
                ObservableCollection<Elev> result = new ObservableCollection<Elev>();


                SqlParameter clasaId = new SqlParameter("@clasaID", clasaID);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(clasaId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Elev r = new Elev();
                    r.IdPers = reader.GetInt32(0);
                    r.Nume = reader.GetString(1);
                    r.Prenume = reader.GetString(2);
                    r.IdElev = reader.GetInt32(3);
                    r.ClasaFrecv = new Clasa(reader.GetInt32(4), reader.GetString(5), new Specializare(reader.GetInt32(6), reader.GetString(7)));
                    result.Add(r);
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
