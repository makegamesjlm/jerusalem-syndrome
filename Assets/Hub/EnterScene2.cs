using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterScene2 : MonoBehaviour
{
    public static bool shouldEnterScene = false;
    void OnTriggerEnter(Collider other)
    {
        Image image = GetComponent<Image>();
        image.color = Color.red;
        shouldEnterScene = true;
    }

    void OnTriggerExit(Collider other)
    {
        Image image = GetComponent<Image>();
        image.color = Color.white;
        shouldEnterScene = false;
    }
}
