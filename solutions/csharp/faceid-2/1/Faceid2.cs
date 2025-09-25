public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public bool Equals(FacialFeatures otherFacialFeatures)
    {
        return this.EyeColor == otherFacialFeatures.EyeColor && this.PhiltrumWidth == otherFacialFeatures.PhiltrumWidth;     
    }

    public override int GetHashCode()
    {
        HashCode hashCode = new HashCode();
        hashCode.Add(this.EyeColor);
        hashCode.Add(this.PhiltrumWidth);
        return hashCode.ToHashCode();
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public bool Equals(Identity other)
    {
        return this.Email == other.Email && this.FacialFeatures.Equals(other.FacialFeatures);
    }

    public override int GetHashCode()
    {
        HashCode hashCode = new HashCode();
        hashCode.Add(this.Email);
        hashCode.Add(this.FacialFeatures.GetHashCode());
        return hashCode.ToHashCode();
    }
}

public class Authenticator
{
    private HashSet<Identity> _identities = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Email == "admin@exerc.ism" && identity.FacialFeatures.Equals(new FacialFeatures("green", 0.9m));
    }

    public bool Register(Identity identity)
    {
        if (IsRegistered(identity)) return false;
        _identities.Add(identity);
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
        foreach (var x in _identities)
        {
            if (x.Equals(identity)) return true;
        }

        return false;
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return System.Object.ReferenceEquals(identityA, identityB);
    }
}
