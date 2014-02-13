using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
/// <summary>
/// Summary description for Class1
/// </summary>
public class PasswordHash
{
    private string passwd;
    private string passkey;

    public Byte[] HashIt(string password, string passkey)
	{
        passwd = password;
        this.passkey = passkey;
        Byte[] originalBytes;
        Byte[] encodedBytes;
        SHA512 shaHash= SHA512.Create();
        string passToHash = passkey + password;
        originalBytes = ASCIIEncoding.Default.GetBytes(passToHash);
        encodedBytes = shaHash.ComputeHash(originalBytes);
        return encodedBytes;
    }
}