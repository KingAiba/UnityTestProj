using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject mainball;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - mainball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainball)
        {
            transform.position = mainball.transform.position + offset;
        }
        else
        {
            transform.position = transform.position;
        }
        
    }
}
