namespace LoginAPI.Security;

public static class PasswordHasher
{
    public static string Hash(string pass)
    {
        return BCrypt.Net.BCrypt.HashPassword(pass);
    }
    public static bool Verify(string plaiPass, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(plaiPass, hashedPassword);
    }
}
