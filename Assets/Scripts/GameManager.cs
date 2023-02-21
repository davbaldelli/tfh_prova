using Cards;
using Enemies;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    PlayerStats stats;
    [SerializeField]
    EnemyObject enemy;
    public PlayerData playerData;
    public EnemyData enemyData;
    

    GameManagerGateway gateway;

    void Start()
    {
        stats.StartingDeck.Shuffle();
        playerData = new PlayerData(stats.life, stats.attackMult, stats.defenseMult, new Stack<Card>(stats.StartingDeck), stats.heandCardsCount);
        enemyData = new EnemyData(enemy.name, enemy.life, 1, 1);
        gateway = new GameMangerGatewayImpl(playerData, enemyData);
        gateway.startGame();
    }
}

internal static class IListExensions
{
    static System.Random random = new System.Random();
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}


