abstract class Character
{
    public bool Isprepared = false;
    public string characterType = "";
    protected Character(string characterType)
    {
        this.characterType = characterType;
      
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        if(!Isprepared){
            return true;
        }
        return false;
    }
    public override string ToString()
    {
       return $"Character is a {characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }
    public override bool Vulnerable()
    {
        return false;
    }
    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable()){
            return 10;
            
        }
        return 6;
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
       if(Isprepared){
            return 12;
       }
       else{
        return 3;
       }
    }

    public void PrepareSpell()
    {
        this.Isprepared = true;
    }
}
