using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLogic : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _sizeRoad;

    private void Awake()
    {
        _sizeRoad = GetComponent<Renderer>().bounds.extents.z*2;
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, _spawnPoint.position.z);
    }
}
