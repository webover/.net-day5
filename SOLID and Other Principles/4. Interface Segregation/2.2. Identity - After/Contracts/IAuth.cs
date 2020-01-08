namespace InterfaceSegregationIdentityAfter.Contracts
{
    public interface IAuth
    {
        void Register(string username, string password);

        void Login(string username, string password);
    }
}
