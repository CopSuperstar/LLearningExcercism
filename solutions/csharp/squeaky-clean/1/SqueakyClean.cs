using System.Linq;
using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        string cleaned1 = string.Concat(identifier.Select(w=>w ==' '? '_':w));
        var sb = new StringBuilder();
        foreach (char c in cleaned1)
        {
            if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }
            else
            {
                sb.Append(c);
            }
        }
        string cleaned2 = sb.ToString();

        bool nextUpper = false;
         var sb2 = new StringBuilder();
        foreach (char c in cleaned2)
        {
            if (!(c == '-'))
            {
                char l = nextUpper == true? char.ToUpper(c):c; 
                sb2.Append(l);
                nextUpper = false;
            }
            if (c == '-')
            {
                nextUpper = true;
                continue;
            }
            
        }
        string cleaned3 = sb2.ToString();

        var sb4 = new StringBuilder();
        foreach (char c in cleaned3)
        {
           if (char.IsLetter(c) || c == '_') 
{
    if (!((c >= 'α') && (c <= 'ω'))) 
    {
        sb4.Append(c);
    }
}

        }
        string cleaned4 = sb4.ToString();
        return cleaned4;


    }
}
