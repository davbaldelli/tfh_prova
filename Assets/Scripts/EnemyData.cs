using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyData : MonoBehaviour
    {

        [SerializeField]
        GameObject gameManager;
        [SerializeField]
        TMP_Text text;
        GameManager manager;

        void Start()
        {
            manager = gameManager.GetComponent<GameManager>();
        }

        private void Update()
        {
            if (manager.matchData != null)
            {
                text.text = manager.matchData.enemyHealth.ToString();
                Debug.Log($"Enemy healt {manager.matchData.enemyHealth}");
            }
        }
    }
}