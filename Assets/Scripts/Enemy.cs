using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 targetPosition;
    private Vector3 _startPosition;

    public float moveSpeed;
    private bool _movingToTargetPos;

    private void Start()
    {
        _startPosition = transform.position;
        _movingToTargetPos = true;
    }

    private void Update()
    {
        if (_movingToTargetPos == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (transform.position == targetPosition)
            {
                _movingToTargetPos = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _startPosition, moveSpeed * Time.deltaTime);

            if (transform.position == _startPosition)
            {
                _movingToTargetPos = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<Player>().GameOver();
        }
    }
}
