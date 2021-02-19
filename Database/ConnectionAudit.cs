using Domain.Order;
using System;
using System.Data.SqlClient;

namespace Database
{
    public class ConnectionAudit
    {
        SqlCommand _cmd = null;
        SqlConnection _con = null;


        public void insertAudit(RawInfo rawinfo)
        {

            _con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;database=Moving;Integrated Security=True");
            _con.Open();
            string insertQuery = "USE [Moving] INSERT INTO [dbo].[Audit] VALUES(" + rawinfo.Identification + ",'" + rawinfo.Date.ToLocalTime() + "')";
            _cmd = new SqlCommand(insertQuery, _con);
            try
            {
                _cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                _con.Close();
            }
            finally
            {
                _con.Close();
            }
        }
    }
}
