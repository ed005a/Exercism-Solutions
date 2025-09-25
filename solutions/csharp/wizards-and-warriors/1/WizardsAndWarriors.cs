abstract class Character
{
    protected string _characterType;
    protected bool _vulnerable;
    protected Character(string characterType)
    {
        _characterType = characterType;
        _vulnerable = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => _vulnerable;

    public override string ToString() => $"Character is a {_characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable()) 
            return 10;
        return 6;
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
        _vulnerable = true;
    }

    public override int DamagePoints(Character target)
    {
        if (!_vulnerable)
        {
            _vulnerable = true;
            return 12;
        }
        return 3;
    }

    public void PrepareSpell()
    {
        _vulnerable = false;
    }
}
