public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char,int> dict = new()
        {
          ['A'] = 0,   ['C'] = 0, ['G'] = 0, ['T'] = 0
        };
        string test = "GATC";
        foreach (char c in sequence)
        {
            if (!test.Contains(c)) throw new ArgumentException();
            else
            {
                dict[c] +=1;
            }
        }
       return dict;
    }
}