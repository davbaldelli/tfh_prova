using Assets.Scripts.Cards;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        PlayerStats stats;
        [SerializeField]
        Deck deck;
        Card[] startingCards = new Card[] {new Gunslinger(), new Gunslinger(), new Renegade()};

        GameManagerGateway gateway;

        void Start()
        {
            gateway = new GameMangerGatewayImpl(deck, stats);
            gateway.startGame(startingCards);
        }
    }
}