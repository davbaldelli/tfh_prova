using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CardEffectGameGatewayImpl : CardEffectGameGateway
    {
        [SerializeField]
        Deck deck;
        [SerializeField]
        PlayerStats playerStats;
        public override void addLife(int amount)
        {
            playerStats.life += amount;
        }

        public override void drawCard()
        {
            deck.drawCard(); 
        }

        public override void moultiplyAttack(int amount)
        {
            playerStats.attackMult += amount;
        }
    }
}