namespace BlazorApp2.Components.Models;

public class UsdUser
{
    public static List<SaveUser> _usdUser = new List<SaveUser>();
}
public class SaveUser
{
    public string? Login { get; set; }
    public string? PasswordUser { get; set; }
    public string? Fio { get; set; }
    public int RoleUser { get; set; }
}