using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
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
        if (manager.playerData != null)
        {
            //Debug.Log($"Player health {manager.matchData.playerHealth}");
        }
    }
}