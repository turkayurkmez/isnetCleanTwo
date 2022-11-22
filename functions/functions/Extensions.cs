namespace functions
{
    public static class Extensions
    {
        public static bool IsInRole(this Customer customer, string role)
        {
            return customer.Role.ToLower() == role.ToLower();
        }
    }
}
