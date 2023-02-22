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
    

    IGameManagerGateway gateway;

    void Start()
    {
        stats.startingDeckTemplate.Shuffle();
        playerData = new PlayerData(stats.life, stats.attackMult, stats.defenseMult, new Stack<ICard>(stats.getStartingDeck()), stats.heandCardsCount);
        enemyData = new EnemyData(enemy.name, enemy.life, 1, 1);
        gateway = new GameMangerGateway(playerData, enemyData);
        gateway.startGame();
        playerData.hand[0].life = 55;
        foreach(ICard card in playerData.hand)
        {
            Debug.Log($"{card.cardName} -> {card.life}");
        }
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


