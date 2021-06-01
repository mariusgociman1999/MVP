using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class ProfesorDA
    {
        public Profesor GetProf(int persID)
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetProfData", con);
                Profesor result = new Profesor();
                result.Clase = new List<Clasa>();
                result.MateriiPred = new List<Materie>();

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
                    result.IdProf = reader.GetInt32(3);
                    while (reader.Read())
                    {
                        result.Clase.Add(new Clasa(reader.GetInt32(4), reader.GetString(5), new Specializare(reader.GetInt32(6), reader.GetString(7))));
                        result.MateriiPred.Add(new Materie(reader.GetInt32(8), reader.GetString(9)));
                    }
                    
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
        public void AddProf(Profesor prof)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddElev", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter profNume = new SqlParameter("@nume", prof.Nume);
            SqlParameter profPrenume = new SqlParameter("@prenume", prof.Prenume);
            SqlParameter clasaProf = new SqlParameter("@clasa", prof.Clase[0].IdClasa);

            cmd.Parameters.Add(profNume);
            cmd.Parameters.Add(profPrenume);
            cmd.Parameters.Add(clasaProf);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModProf(Profesor prof)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModProf", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter persId = new SqlParameter("@persID", prof.IdPers);
            SqlParameter profId = new SqlParameter("@profID", prof.IdProf);
            SqlParameter profNume = new SqlParameter("@nume", prof.Nume);
            SqlParameter profPrenume = new SqlParameter("@prenume", prof.Prenume);

            cmd.Parameters.Add(profId);
            cmd.Parameters.Add(profNume);
            cmd.Parameters.Add(profPrenume);
            cmd.Parameters.Add(persId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
