using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for ManagePerson
/// </summary>
public class ManagePerson
{
    private Donation d;
    private Person p;
    private SqlConnection connect;
  
	public ManagePerson(Donation don, Person per)
	{
        d=don;
        p=per;
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
    }
    public void WritePerson()
    {
        string sql = "insert into Person(PersonLastName, PersonFirstName,PersonUserName, PersonPlainPassword, PersonPassKey, PersonEntrydate,PersonUserPassword) Values (@last, @first,@email, @pass,@passk,@date,@hpass)";
        PassCodeGenerator psg = new PassCodeGenerator();
        PasswordHash ph = new PasswordHash();
        int passkey = psg.GetPassCode();
        DateTime now= DateTime.Now;
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@last", p.LastName);
        cmd.Parameters.AddWithValue("@first", p.Firstname);
        cmd.Parameters.AddWithValue("@email", p.Email);
        cmd.Parameters.AddWithValue("@pass", p.Password);
        cmd.Parameters.AddWithValue("@passk", passkey);
        cmd.Parameters.AddWithValue("@date", now);
        cmd.Parameters.AddWithValue("@hpass",ph.HashIt(p.Password, passkey.ToString()));
      
        connect.Open();
        cmd.ExecuteNonQuery();
        connect.Close();
    }
   
    public void WriteDonate(int personkey)
    {
        string sql = "insert into Donation(DonationAmount, DonationDate, Personkey ) Values (@amount, @date,@personkey)";
        DateTime now = DateTime.Now;
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@personkey", personkey);
        cmd.Parameters.AddWithValue("@amount", d.Amount);
        cmd.Parameters.AddWithValue("@date",now);
        
        connect.Open();
        cmd.ExecuteNonQuery();
        connect.Close();
    }
    
    
}