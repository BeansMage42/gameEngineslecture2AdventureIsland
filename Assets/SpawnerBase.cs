using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerBase : MonoBehaviour
{
    [SerializeField] protected GameObject enemyToSpawn;

    public abstract void Spawn();


}
