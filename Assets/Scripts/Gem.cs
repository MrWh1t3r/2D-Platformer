using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public int value = 1;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            col.collider.GetComponent<Player>().AddScore(value);
            Destroy(gameObject);
        }
    }
}
