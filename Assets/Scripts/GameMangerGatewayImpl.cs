using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameMangerGatewayImpl : GameManagerGateway
    {
        [SerializeField]
        Deck deck;
        [SerializeField]
        PlayerStats playerStats;
        public override void drawCards()
        {
            if(playerStats.hand.Length < 5)
            {
                for (int i = 0; i < 5 - playerStats.hand.Length; i++)
                    deck.drawCard();
            }
        }

        public override void finishTurn()
        {
            //do stuff
        }

        public override void startGame()
        {
            playerStats.life = 100;
            playerStats.attackMult = 1;
            for (int i = 0; i < 5; i++)
            {
                deck.drawCard();
            }
        }
    }
}