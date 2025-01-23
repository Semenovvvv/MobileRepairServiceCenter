namespace MobileRepair.Constants
{
    public class RoleConstants
    {
        public const string Admin = "Admin";
        public const string Employee = "Employee";
        public const string Client = "Client";

        public static IList<string> GetRoleList() => new List<string>() { Admin, Client, Client };
    };
}
