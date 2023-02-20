using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        GameManagerGateway gateway;
        // Use this for initialization
        void Start()
        {
            gateway.startGame();
        }
    }
}