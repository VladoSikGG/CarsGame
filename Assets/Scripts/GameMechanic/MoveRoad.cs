using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    private float _speed;
    [SerializeField] private PlayerSettings _playerSet;

    private void Awake()
    {
        _speed = _playerSet.GetSpeed();
    }
    private void Update()
    {
        transform.position -= new Vector3(0,0, _speed * Time.deltaTime * 10);
    }
}
