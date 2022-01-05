using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterScript : MonoBehaviour
{
    public float forceMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {


    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball collided");

        if (collision.gameObject.CompareTag("mainBall"))
        {
            Debug.Log("pushed forward:"+collision.relativeVelocity);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.right * forceMultiplier , ForceMode.Impulse);
            Debug.Log("pushed forward" + collision.relativeVelocity);
        }
    }
}
