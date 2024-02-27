using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCategory : MonoBehaviour
{
    [SerializeField] private GameObject _gridCarSkins, _gridRoadSkins;

    public void SelectCarCategory()
    {
        _gridCarSkins.SetActive(true);
        _gridRoadSkins.SetActive(false);
    }

    public void SelectRoadCategory()
    {
        _gridCarSkins.SetActive(false);
        _gridRoadSkins.SetActive(true);
    }
}
