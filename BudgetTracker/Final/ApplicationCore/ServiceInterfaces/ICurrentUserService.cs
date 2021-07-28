namespace ApplicationCore.ServiceInterfaces
{
    public interface ICurrentUserService
    {
        int UserId { get; }
        bool IsAuthenticated { get; }
        string Email { get; }
        string FullName { get; }
    }
}