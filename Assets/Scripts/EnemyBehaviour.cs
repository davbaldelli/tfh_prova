using TMPro;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
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
        if (manager.enemyData != null)
        {
            text.text = $"{manager.enemyData.name} -> {manager.enemyData.enemyHealth}";
            //Debug.Log($"Enemy health {manager.matchData.enemyHealth}");
        }
    }
}