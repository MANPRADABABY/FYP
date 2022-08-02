using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Summary description for Clients
/// </summary>
public class RegexValidation
{
    public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]";
    public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}";
    public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
    public static string ADDRESS_REGEX = "^[A-Z]{1}[A-Za-z]";

    public bool ValidateFirstName()
    {
        return RegexValidation.IsMatch(name, NAME_REGEX);
    }
    public bool ValidateEmail()
    {
        return RegexValidation.IsMatch(email, EMAIL_REGEX);
    }
    public bool ValidateMobileNumber()
    {
        return RegexValidation.isMatch(phone, MOBILENUMBER_REGEX);
    }
    public bool validateADDRESS_REGEX()
    {
        return RegexValidation.isMatch(address, ADDRESS_REGEX);
    }

}

