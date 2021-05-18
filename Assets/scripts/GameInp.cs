﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Debug.Log("r pressed");
            SceneManager.LoadScene("game");
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
