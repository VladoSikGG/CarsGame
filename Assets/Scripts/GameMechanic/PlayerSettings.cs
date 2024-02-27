using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    [Header ("Values")]
    [SerializeField] private float _speed;

    [Header("Objects' Tags")]
    [SerializeField] private string _tagEnemy, _tagCoin;

    [SerializeField] private GameObject[] _modelPlayer;
    [SerializeField] private GameObject _deathPanel;

    [SerializeField] private float _currentScore = 0;

    private void Start()
    {
        Time.timeScale = 1;
        Instantiate(_modelPlayer[PlayerPrefs.GetInt("currentSkin")], gameObject.transform);
    }

    private void Update()
    {
        _currentScore += Time.deltaTime;
        print((int)_currentScore);
    }
    public float GetSpeed()
    {
        return _speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == _tagEnemy)
        {
            Destroy(gameObject);
            _deathPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if (collision.gameObject.tag == _tagCoin)
        {
            int value = collision.gameObject.GetComponent<BonusSetting>().GetCoinValue();
            AddCoin(value);
        }
    }

    private void AddCoin(int value)
    {
        int tempCoins = PlayerPrefs.GetInt("coins") + value;
        PlayerPrefs.SetInt("coins", tempCoins);
    }
}
