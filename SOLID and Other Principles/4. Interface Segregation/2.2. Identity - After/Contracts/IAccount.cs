namespace InterfaceSegregationIdentityAfter.Contracts
{
    using System.Collections.Generic;

    public interface IAccount
    {
        void ChangePassword(string oldPass, string newPass);       
    }
}
