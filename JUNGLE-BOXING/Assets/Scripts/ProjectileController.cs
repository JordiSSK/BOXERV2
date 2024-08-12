using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float _damage;
    private bool _isPercentage;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _rigidbody.velocity = Vector2.right * speed * Time.deltaTime;
    }

    public void Go(float damage, bool isPercentage)
    {
        _damage = damage;
        _isPercentage = isPercentage;
        gameObject.SetActive(true);
    }
}
