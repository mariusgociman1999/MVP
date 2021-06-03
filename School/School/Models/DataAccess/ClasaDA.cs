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
    class ClasaDA
    {
        public ObservableCollection<Clasa> GetClase()
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetClase", con);
                ObservableCollection<Clasa> result = new ObservableCollection<Clasa>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Clasa p = new Clasa();
                    p.IdClasa = reader.GetInt32(0);
                    p.Descriere = reader.GetString(1).TrimEnd();
                    p.Special = new Specializare();
                    p.Special.IdSpecializare = reader.GetInt32(2);
                    p.Special.Descriere = reader.GetString(3).TrimEnd();
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

        public void AddClasa(Clasa clasa)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddClasa", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter clasaDesc = new SqlParameter("@descClasa", clasa.Descriere);
            SqlParameter clasaSpec = new SqlParameter("@specialID", clasa.Special.IdSpecializare);

            cmd.Parameters.Add(clasaDesc);
            cmd.Parameters.Add(clasaSpec);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModClasa(Clasa clasa)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModClasa", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter clasaId = new SqlParameter("@clasaID", clasa.IdClasa);
            SqlParameter clasaDesc = new SqlParameter("@descClasa", clasa.Descriere);
            SqlParameter clasaSpec = new SqlParameter("@specialID", clasa.Special.IdSpecializare);

            cmd.Parameters.Add(clasaId);
            cmd.Parameters.Add(clasaDesc);
            cmd.Parameters.Add(clasaSpec);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
