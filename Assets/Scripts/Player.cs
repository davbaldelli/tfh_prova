using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        PlayerStats stats;
        [SerializeField]
        Deck deck;

        CardEffectGateway cardEffectGateway;

        private void Start()
        {
            cardEffectGateway = new CardEffectGatewayImpl(deck, stats);
        }
    }
}