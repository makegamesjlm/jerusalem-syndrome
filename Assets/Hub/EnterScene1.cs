using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterScene1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Image image = GetComponent<Image>();
        image.color = Color.red;
    }

    void OnTriggerExit(Collider other)
    {
        Image image = GetComponent<Image>();
        image.color = Color.white;
    }
}
