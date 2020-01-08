namespace InterfaceSegregationIdentityAfter.Contracts
{
    using System.Collections.Generic;

    interface IFindUser
    {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
