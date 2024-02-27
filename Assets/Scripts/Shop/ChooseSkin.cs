using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChooseSkin : MonoBehaviour
{
    [SerializeField] private Image _imgSelected;
    [SerializeField] private int _index;
    [SerializeField] private bool _isLock;
    [SerializeField] private TypeSkin _typeSkin;
    private string _strSkinName;

    private void Start()
    {
        
        if (_typeSkin == TypeSkin.road) _strSkinName = "road"+ _index.ToString();
        else if (_typeSkin == TypeSkin.car) _strSkinName = "car" + _index.ToString();
    }

    private void Update()
    {
        CheckIsSelectedSkin();
        print(_strSkinName + PlayerPrefs.GetInt(_strSkinName));
    }

    public void ClickSkin()
    {
        print(PlayerPrefs.GetString(_strSkinName));
        if (PlayerPrefs.GetString(_strSkinName) == string.Empty)
        {
            SelectUnlockedSkin();
        }
    }

    private void SelectUnlockedSkin()
    {
        _imgSelected.gameObject.SetActive(true);
        PlayerPrefs.SetInt("currentSkin", _index);

    }

    private void UnSelectUnlockedSkin()
    {
        _imgSelected.gameObject.SetActive(false);
        PlayerPrefs.SetInt(_strSkinName, 0);
    }

    private void CheckIsSelectedSkin()
    {
        if (PlayerPrefs.GetInt("currentSkin") != _index)
        {
            UnSelectUnlockedSkin();
        }
        else SelectUnlockedSkin();
    }

}

public enum TypeSkin
{
    road,
    car
}
