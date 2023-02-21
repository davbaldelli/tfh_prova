using Cards;

public class EnemyData
{
    public string name;
    public int enemyHealth;
    public float attackMultiplier;
    public float defenseMultiplier;
    public Card[] enemyBoard;
    //enemy sign board

    public EnemyData(string name, int enemyHealth, float attackMultiplier, float defenseMultiplier)
    {
        this.name = name;
        this.enemyHealth = enemyHealth;
        this.attackMultiplier = attackMultiplier;
        this.defenseMultiplier = defenseMultiplier;
    }

}
