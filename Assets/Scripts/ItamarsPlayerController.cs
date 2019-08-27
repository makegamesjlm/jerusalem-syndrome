using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItamarsPlayerController : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 25;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
