using System;
public class Robot
{
    private Random rand = new();
    private string _name;
    static private HashSet<string> names = new();

    private string GenerateNewName()
    {
        char letter1 = (char)('A' + rand.Next(26));
        char letter2 = (char)('A' + rand.Next(26));
        int number = rand.Next(1000);
        return $"{letter1}{letter2}{number:D3}";
    }

    private string GenerateNewUniqueName()
    {
        string name;
        do
        {
           name =  GenerateNewName(); 
        } while(!names.Add(name));

        return name;
    }
    public string Name
    {
        get
        {
            if (_name == null)
            {
                _name = GenerateNewUniqueName();
            }

            return _name;
        }
    }

    public void Reset() => _name = null;
}