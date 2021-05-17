using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinalKey : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("col detected");

        if (collision.gameObject.layer == 8)
        {
            Debug.Log("key hit");
    
            Destroy(gameObject);

            SceneManager.LoadScene("win");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
