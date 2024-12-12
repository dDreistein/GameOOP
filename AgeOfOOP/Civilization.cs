using System.ComponentModel;

namespace AgeOfOOP;

public abstract class Civilization(string name, Architecture architectureStyle, Wonder wonder, int offense, int defense)
{
    private string name { get; set; }  = name;
    private Architecture ArchitectureStyle { get; set; } = architectureStyle;
    private Wonder Wonder { get; set; } = wonder;
    private int Offense { get; set; } = offense;
    private int Defense { get; set; } = defense;
    
    
    private Age Age { get; set; } = Age.StoneAge;
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
        UpgradePoints -= 100* (int)Age;
        Age++;
    }

    public void UpgradeHealth()
    {
        Health++;
    }

    public void War()
    {
        Health--;
    }

    public override string ToString()
    {
        string toString;
        string wonder;
        switch ((int)Wonder)
        {
            case 0:
                wonder = "🏯";
                break;
            case 1:
                wonder = "🔺";
                break;
            case 2:
                wonder = "🏛️";
                break;
            case 3:
                wonder = "🏺";
                break;
            default:
                wonder = "";
                break;
        }

        string age;
        switch ((int) Age)
        {
            case 0:
                age = "Stone Age";
                break;
            case 1:
                age = "Tool Age";
                break;
            case 2:
                age = "Bronze Age";
                break;
            case 3:
                age = "Iron Age";
                break;
            default:
                age = "";
                break;
        }
        string healthBar = new string('■', (int)Health/4 + 26);
        healthBar += new string('□', 51-((int)Health/4 + 26));
        
        toString = $"---------------------------------------------------\n" +
                   $"{name} {wonder}\tAge: {age}\n" +
                   $"---------------------------------------------------\n" +
                   $"Offense: {Offense}\tDefense: {Defense}\n" +
                   $"Health:\n" +
                   $"                         |                         \n" +
                   $"{healthBar}\n" +
                   $"Population: {Population}\tUpgrade Points: {UpgradePoints}\n" +
                   $"---------------------------------------------------\n" +
                   $"[1] Angriff\t[2] Technologie";
        return toString;
    }
}