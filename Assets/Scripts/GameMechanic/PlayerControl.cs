using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Vector3 TouchPos;

    void Update()
    {
        if (Input.GetMouseButton(0)) //0 - левая кнопка мыши, а на телефонах обычный клик
        {
            float distanceBetweenPlayerAndCamera = Camera.main.transform.position.y - transform.position.y;
            TouchPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceBetweenPlayerAndCamera)); //x
            print(TouchPos);
        }
        transform.position = new Vector3(TouchPos.x, transform.position.y, transform.position.z);
    }
}
