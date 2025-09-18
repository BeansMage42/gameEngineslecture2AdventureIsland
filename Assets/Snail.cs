using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail : EnemyBase
{

    private float timer;
    private float maxTime = 2;
    private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        timer = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer-=Time.deltaTime;
        }
        else
        {

            timer = maxTime;
            if (state)
            {
                state = false;
                transform.position += Vector3.up *2;
                transform.localScale = transform.lossyScale + (Vector3.up * 2) ;
            }
            else
            {
                state = true;
                transform.localScale = transform.lossyScale - (Vector3.up * 2);
            }
        }
    }

    public override void Death()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Throw")
        {
            Death();
        }
    }
}
