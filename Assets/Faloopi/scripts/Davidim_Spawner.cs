using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Davidim_Spawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject Davidim;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newdavidim = Instantiate(Davidim);
        newdavidim.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newdavidim = Instantiate(Davidim);
            newdavidim.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newdavidim, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
