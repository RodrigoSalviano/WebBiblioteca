using System.Security.Cryptography;
using System.Text;
public static class FakeUserRepository
{
    private static string Hash(string input)
    {
        using var sha = SHA256.Create();
        return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(input)));
    }

    private static readonly Dictionary<string,string> Users=new(){
        {"admin", Hash("123456")}
    };

    public static bool ValidateUser(string u,string p)
    {
        return Users.ContainsKey(u) && Users[u]==Hash(p);
    }
}
