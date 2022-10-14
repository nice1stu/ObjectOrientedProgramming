Login login = new Login();
login.Password = "12345";
Console.WriteLine(login.Password);

public class Login
{
    private string password;

    public string Password
    {
        set { password = value; }
    }
}