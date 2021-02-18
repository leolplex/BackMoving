using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class ConnectionAudit
    {
        SqlCommand _cmd = null;
        SqlConnection _con = null;


        public void insertAudit(Audit audit)
        {

            _con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;database=Moving;Integrated Security=True");
            _con.Open();
            string insertQuery = "USE [Moving] INSERT INTO [dbo].[Audit] VALUES(" + audit.Identification + ",'" + audit.Date.ToLocalTime() + "')";
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
