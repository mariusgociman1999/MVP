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
    class NotaDA
    {
        public ObservableCollection<Nota> GetNote(int elevID)
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetNoteElev", con);
                ObservableCollection<Nota> result = new ObservableCollection<Nota>();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter elevId = new SqlParameter("@elevID", elevID);
                cmd.Parameters.Add(elevId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Nota n = new Nota();
                    n.IdNota = reader.GetInt32(0);
                    n.Valoare = reader.GetDecimal(1);
                    n.Data = reader.GetDateTime(2);
                    n.Teza = reader.GetBoolean(3);
                    n.Materie = new Materie(reader.GetInt32(4), reader.GetString(5).TrimEnd());
                    result.Add(n);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddNota(int idElev, Nota nota)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddNota", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter matId = new SqlParameter("@materieID", nota.Materie.IdMaterie);
            SqlParameter elevId = new SqlParameter("@elevID", idElev);
            SqlParameter val = new SqlParameter("@nota", nota.Valoare);
            SqlParameter teza = new SqlParameter("@teza", nota.Teza);
            SqlParameter data = new SqlParameter("@data", nota.Data);

            cmd.Parameters.Add(matId);
            cmd.Parameters.Add(elevId);
            cmd.Parameters.Add(val);
            cmd.Parameters.Add(teza);
            cmd.Parameters.Add(data);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModNota(int idElev, Nota nota)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModNota", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter notaId = new SqlParameter("@notaID", nota.IdNota);
            SqlParameter matId = new SqlParameter("@materieID", nota.Materie.IdMaterie);
            SqlParameter elevId = new SqlParameter("@elevID", idElev);
            SqlParameter val = new SqlParameter("@nota", nota.Valoare);
            SqlParameter teza = new SqlParameter("@teza", nota.Teza);
            SqlParameter data = new SqlParameter("@data", nota.Data);

            cmd.Parameters.Add(notaId);
            cmd.Parameters.Add(matId);
            cmd.Parameters.Add(elevId);
            cmd.Parameters.Add(val);
            cmd.Parameters.Add(teza);
            cmd.Parameters.Add(data);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
