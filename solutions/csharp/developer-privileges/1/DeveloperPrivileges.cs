public class Authenticator
{
    // TODO: Implement the Authenticator.Admin property
    public Authenticator()
    {
        Admin = new Identity
        {
            Email = "admin@ex.ism", FacialFeatures = new FacialFeatures { EyeColor = "green", PhiltrumWidth = 0.9m },
            NameAndAddress = new List<string> { "Chanakya", "Mumbai", "India" }
        };
        Developers = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity
            {
                Email = "bert@ex.ism", FacialFeatures = new FacialFeatures { EyeColor = "blue", PhiltrumWidth = 0.8m },
                NameAndAddress = new List<string> { "Bertrand", "Paris", "France" }
            },
            ["Anders"] = new Identity
            {
                Email = "anders@ex.ism",
                FacialFeatures = new FacialFeatures { EyeColor = "brown", PhiltrumWidth = 0.85m },
                NameAndAddress = new List<string> { "Anders", "Redmond", "USA" },
            },
        };
    }
    public Identity Admin { get; }

    // TODO: Implement the Authenticator.Developers property
    public IDictionary<string, Identity> Developers { get; }
}

//**** please do not modify the FacialFeatures class ****
public class FacialFeatures
{
    public required string EyeColor { get; set; }
    public required decimal PhiltrumWidth { get; set; }
}

//**** please do not modify the Identity class ****
public class Identity
{
    public required string Email { get; set; }
    public required FacialFeatures FacialFeatures { get; set; }
    public required IList<string> NameAndAddress { get; set; }
}
