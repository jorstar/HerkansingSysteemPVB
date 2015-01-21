using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Functies
/// </summary>
public class Functies
{
    public static string CalculateHashedPassword(string clearpwd, string loginnaam)
    {
        using (var sha = System.Security.Cryptography.SHA256.Create())
        {
            var computedHash = sha.ComputeHash(System.Text.Encoding.Unicode.GetBytes(clearpwd + loginnaam.ToUpper()));

            return Convert.ToBase64String(computedHash);
        }
    }

    public static bool CheckWWChange(string objSessionUser, string objSessionRole)
    {
        herkansingDBEntities entity = new herkansingDBEntities();

        if (objSessionRole == "S")
        {
            return Convert.ToBoolean(entity.GetStudentFirstLogin(objSessionUser).First());
        }
        else if (objSessionRole == "D")
        {
            return Convert.ToBoolean(entity.GetDocentFirstLogin(objSessionUser).First());
        }
        else return false;
    }
}