using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public abstract class Card : MonoBehaviour
{
    [SerializeField]
    CardEffect[] effects;
}
