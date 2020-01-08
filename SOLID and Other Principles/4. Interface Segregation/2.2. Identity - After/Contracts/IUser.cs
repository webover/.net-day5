namespace InterfaceSegregationIdentityAfter.Contracts
{
    public interface IUser
    {
        bool RequireUniqueEmail { get; set; }

        int MinRequiredPasswordLength { get; set; }

        int MaxRequiredPasswordLength { get; set; }

        string Email { get; }

        string PasswordHash { get; }
    }
}
