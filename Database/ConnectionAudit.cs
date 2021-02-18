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

            _con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
            _con.Open();
            _cmd = new SqlCommand("insert into audit values(" + audit.Identification + ",'" + audit.Date + "')", _con);
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
