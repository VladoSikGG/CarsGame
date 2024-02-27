using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private bool _wasOnScene = false;

    private void Update()
    {
        Move();
    }

    private void OnBecameVisible()
    {
        _wasOnScene = true;
    }

    private void OnBecameInvisible()
    {
        if (_wasOnScene) Destroy(gameObject);
    }

    private void Move()
    {
        transform.position -= new Vector3(0, 0, _speed * Time.deltaTime * 10);
    }
}
