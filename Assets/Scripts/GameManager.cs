﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        PlayerStats stats;
        [SerializeField]
        Deck deck;

        GameManagerGateway gateway;

        void Start()
        {
            gateway = new GameMangerGatewayImpl(deck, stats);
            gateway.startGame();
        }
    }
}