using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbineRotation : MonoBehaviour
{
    [SerializeField] public float y_speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, y_speed, 0);
    }
}
