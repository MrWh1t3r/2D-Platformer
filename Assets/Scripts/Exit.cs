using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour
{
    public bool finalLevel;
    public string nextSceneName;
    
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            if (finalLevel)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
