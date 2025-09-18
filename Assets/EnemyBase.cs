using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    public abstract void Death();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Throw")
        {
            Death();
        }
    }

}
