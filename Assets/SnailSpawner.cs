using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailSpawner : SpawnerBase
{
    // Start is called before the first frame update
    public override void Spawn()
    {
        Instantiate(enemyToSpawn, transform.position, transform.rotation);
        Debug.Log("spawned snail");
    }
}
