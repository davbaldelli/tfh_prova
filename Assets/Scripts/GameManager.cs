﻿using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        int handsCardCount;
        [SerializeField]
        PlayerStats stats;
        [SerializeField]
        EnemyObject cowboySlayer;
        MatchData matchData;

        GameManagerGateway gateway;

        void Start()
        {
            matchData = new MatchData(stats.life, cowboySlayer.life(), stats.deck.ToArray(), handsCardCount);
            gateway = new GameMangerGatewayImpl(matchData, stats);
            gateway.startGame();
        }
    }
}