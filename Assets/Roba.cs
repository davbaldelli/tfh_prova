using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roba : MonoBehaviour
{
    [SerializeField]
    private PlayerStats stats;

    void Start()
    {
        stats.life -= 5;
    }

}
