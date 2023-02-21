using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerData : MonoBehaviour
    {
        [SerializeField]
        GameObject gameManager;
        GameManager manager;

        // Use this for initialization
        void Start()
        {
            manager = gameManager.GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if (manager.matchData != null)
            {
                Debug.Log($"Player healt {manager.matchData.playerHealth}");
            }
        }
    }
}