using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Prof_ClaseDA
    {
        public void AddProfClase(int profID, int clasaID, int materieID)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("AddProfClase", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prof = new SqlParameter("@profID", profID);
            SqlParameter clasa = new SqlParameter("@clasaID", clasaID);
            SqlParameter materia = new SqlParameter("@materieID", materieID);

            cmd.Parameters.Add(prof);
            cmd.Parameters.Add(clasa);
            cmd.Parameters.Add(materia);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModProfClase(int profID, int clasaID, int materieID)
        {
            SqlConnection con = DAHelper.Connection;
            SqlCommand cmd = new SqlCommand("ModProfClase", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prof = new SqlParameter("@profID", profID);
            SqlParameter clasa = new SqlParameter("@clasaID", clasaID);
            SqlParameter materia = new SqlParameter("@materieID", materieID);

            cmd.Parameters.Add(prof);
            cmd.Parameters.Add(clasa);
            cmd.Parameters.Add(materia);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
