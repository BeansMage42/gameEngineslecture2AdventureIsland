using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    public static SpawningManager Instance;

    public SpawnerBase[] spawners;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var spawner in spawners)
        {
            spawner.Spawn();
        }
    }

}
