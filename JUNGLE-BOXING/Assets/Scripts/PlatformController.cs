using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float distance;

    private Vector3 _originalPosition;
    private Vector3 _targetPosition;
    private void Awake()
    {
        _originalPosition = transform.position;
        _targetPosition = _originalPosition;
        _targetPosition.x += distance;
    }

    private void FixedUpdate()
    {
        float time = Mathf.PingPong(Time.time * speed, 1.0F);
        Vector3 position = Vector3.Lerp(_originalPosition, _targetPosition, time);
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = gameObject.transform;
        }
    }    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = null;
        }
    }
}
