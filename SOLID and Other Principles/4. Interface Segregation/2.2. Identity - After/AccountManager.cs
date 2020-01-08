namespace InterfaceSegregationIdentityAfter
{
    using System.Collections.Generic;

    using InterfaceSegregationIdentityAfter.Contracts;

    public class AccountManager : IAccount
    {
        public bool RequireUniqueEmail { get; set; }

        public int MinRequiredPasswordLength { get; set; }

        public int MaxRequiredPasswordLength { get; set; }        

        public void ChangePassword(string oldPass, string newPass)
        {
            // change password
        }
    }
}
