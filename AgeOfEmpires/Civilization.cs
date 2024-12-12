namespace AgeOfEmpires;

public abstract class Civilization(string architectureStyle, string wonder, int offense, int defense)
{
    private string ArchitectureStyle { get; set; } = architectureStyle;
    private string Wonder { get; set; } = wonder;
    private int Offense { get; set; } = offense;
    private int Defense { get; set; } = defense;
    
    private Age Age { get; set; } = Age.StoneAge;
    private int AgeInt { get; set; } = 1;
    private int UpgradePoints { get; set; } = 100;
    private int Health { get; set; } = 0;
    private int Population { get; set; } = 0;

    public void Cycle()
    {
        Grow(Health);
        UpgradePoints += Population;
    }
    

    public void Grow(int amount)
    {
        Population += amount;
    }

    public void Shrink(int amount)
    {
        Population -= amount;
    }

    public void Evolve()
    {
        UpgradePoints -= 100*AgeInt;
        Age++;
        AgeInt++;
    }

    public void UpgradeHealth()
    {
        Health++;
    }

    public void War()
    {
        Health--;
    }
}