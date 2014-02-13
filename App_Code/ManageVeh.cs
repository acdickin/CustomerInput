using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for ManageVeh
/// </summary>
public class ManageVeh
{
    public string First;
    public string Last;
    SqlConnection connect;
	public ManageVeh()
	{
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
    }
    public DataTable GetDonation(int personkey)
    {
        
        string sql = "select PersonFirstName, PersonlastName, DonationDate, DonationAmount from Person p inner join Donation d on p.personkey=d.personkey where P.personkey= @personkey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@personkey", personkey);
        SqlDataReader reader=null;
     
        DataTable table = new DataTable();
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Dispose();
        connect.Close();
        return table;
        }
    
    public DataTable GetName(int personkey)
    {
        string sql = "select PersonFirstName, PersonlastName from person where personkey=@personkey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@personkey", personkey);
        SqlDataReader reader = null;

        DataTable table = new DataTable();
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Dispose();
        connect.Close();
        return table;
    }
}