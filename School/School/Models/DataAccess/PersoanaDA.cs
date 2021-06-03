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
    class PersoanaDA
    {
        public ObservableCollection<Persoana> GetPeople()
        {
            SqlConnection con = DAHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetPeople", con);
                ObservableCollection<Persoana> result = new ObservableCollection<Persoana>();
                
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Persoana p = new Persoana();
                    p.IdPers = reader.GetInt32(0);
                    p.Nume = reader.GetString(1).TrimEnd();
                    p.Prenume = reader.GetString(2).TrimEnd();
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
    }
}
