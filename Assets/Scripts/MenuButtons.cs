using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("its ok");
        SceneManager.LoadScene(1);
    }

    public void GoToShop()
    {
        SceneManager.LoadScene(2);
    }
}
