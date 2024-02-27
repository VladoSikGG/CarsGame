using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSetting
{
    [SerializeField] private int _coinValue;

    public int GetCoinValue()
    {
        return _coinValue;
    }
}
