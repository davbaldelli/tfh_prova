using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    GameObject gameManager;
    GameManager manager;

    void Start()
    {
        manager = gameManager.GetComponent<GameManager>();
    }

    void Update()
    {
        if (manager.matchData != null)
        {
            Debug.Log($"Player healt {manager.matchData.playerHealth}");
        }
    }
}