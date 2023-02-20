using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class GameManagerGateway : MonoBehaviour
    {
        public abstract void finishTurn();
        public abstract void startGame();
        public abstract void drawCards();
    }
}