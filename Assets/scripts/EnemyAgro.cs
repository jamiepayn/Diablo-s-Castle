using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{

    
    public Transform player;

    public float agroRange;

    public float moveSpeed;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        

        if (distToPlayer < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();

        }
    }

    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            //enemy to left of player 
            rb.velocity = new Vector2(moveSpeed, 0);
        }
        else if (transform.position.x > player.position.x)
        {
            //enemy to right of player
            rb.velocity = new Vector2(-moveSpeed, 0);
        }

    }

   
    
    void StopChasingPlayer()
    {

    }
}
