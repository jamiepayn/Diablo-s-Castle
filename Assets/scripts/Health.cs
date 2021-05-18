using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int damage = 1;

    public int health = 5;

    public Text hpext;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            health -= damage;
        }
            

       
    }

    // Update is called once per frame
    void Update()
    {
        hpext.text = health.ToString();

        if (health <= 0)
       {
           
            SceneManager.LoadScene("death");
       } 
    }

    
}
