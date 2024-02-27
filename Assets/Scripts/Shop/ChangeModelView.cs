using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModelView : MonoBehaviour
{
    [SerializeField] private GameObject[] _modelsView;
    [SerializeField] private GameObject _currentViewModel;

    private void Update()
    {
        if (PlayerPrefs.GetInt("currentSkin") != _currentViewModel.transform.GetChild(0).GetComponent<ModelViewData>().index)
        {
            print("aha");
            Destroy(_currentViewModel.transform.GetChild(0).gameObject);
            Instantiate(_modelsView[PlayerPrefs.GetInt("currentSkin")], _currentViewModel.transform);

        }
    }
}
