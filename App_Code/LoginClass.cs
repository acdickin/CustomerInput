using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{
    string username;
    string password;
    SqlConnection connect;
   
    public string passcode;

    public LoginClass(string usr, string pass)
	{
        username = usr;
        password = pass;
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
    }
     public int ValidateLogin()
    {
        //set the personID to 0
        int personID = 0;
        //create the SQL String
        string sql = "Select * From Person "
            + "Where Personusername=@email and PersonPlainPassWord=@password";
        //create the command object
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@email", username);
        cmd.Parameters.AddWithValue("@password", password);

        //set up the hash
        PasswordHash ph = new PasswordHash();
        Byte[] hashed; 

        SqlDataReader reader = null;
        
        //open the connection+
        connect.Open();
        //execute the reader
        reader = cmd.ExecuteReader();

        //loop through the records
        while (reader.Read())
        {
            //if there is something there
            if (reader["PersonPassKey"] != null)
            {
                //retrieve the passcode
                passcode = reader["PersonPassKey"].ToString();
                //rehash it with the user name
                hashed = ph.HashIt(password, passcode);
                //for comparison purposes I am converting the Byte array to a string
                string passHash=ConvertBytes(hashed);
                //if it matches assign it to the personID
                Byte[] savedPass = (Byte[])reader["PersonUserPassword"];
                //also converting to a string
                string savedHash = ConvertBytes(savedPass);
               
                //if they match return the person key
                if (passHash.Equals(savedHash))
                {
                    
                    personID = (int)reader["PersonKey"];
                    break; //exit the while
                }

            }
        }

        reader.Close();
        connect.Close();

        //return the person id
        return personID;
    }
    

    private string ConvertBytes(Byte[] encodedBytes)
    {
        //bitconverter is a built in method
        //to convert byte arrays to strings
        string x = BitConverter.ToString(encodedBytes);
        //you need to use a regular expression for the conversion
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        //I add an OX before the string as marker
        //of the number system used
        x = rgx.Replace(x, "");
        return "0x" + x;
       
    }
}


