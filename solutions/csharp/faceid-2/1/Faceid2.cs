public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
  public override bool Equals(object obj)
{
     var other = obj as FacialFeatures;
     if (other == null) return false;
     
     return this.EyeColor == other.EyeColor && this.PhiltrumWidth == other.PhiltrumWidth;
        
}
public override int GetHashCode()
{
    return HashCode.Combine(EyeColor, PhiltrumWidth);
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
    public override bool Equals(object obj)
{
     var other = obj as Identity;
     if (other == null) return false;
     
     return this.Email == other.Email && this.FacialFeatures.Equals(other.FacialFeatures);
        
}
public override int GetHashCode()
{
    return HashCode.Combine(Email, FacialFeatures);
}
}

    public class Authenticator
    {
        List<Identity> list = new();
        public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
        {
        return faceA.EyeColor == faceB.EyeColor && faceA.PhiltrumWidth == faceB.PhiltrumWidth;
        }

        public bool IsAdmin(Identity identity) => identity.Email == "admin@exerc.ism" && identity.FacialFeatures.EyeColor == "green" && identity.FacialFeatures.PhiltrumWidth == 0.9m;


        public bool Register(Identity identity)
        {
            if (!IsRegistered(identity))
            {
                list.Add(identity);
                return true;
            }
return false;
        }

        public bool IsRegistered(Identity identity) => list.Contains(identity);
    

        public static bool AreSameObject(Identity identityA, Identity identityB) => Object.ReferenceEquals(identityA, identityB);
    
    }
