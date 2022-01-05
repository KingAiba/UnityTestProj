using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavafloor : MonoBehaviour
{
    public GameObject ExplosionVfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball collided with lava");

        if (collision.gameObject.CompareTag("mainBall"))
        {
            GameObject explosion1 = Instantiate(ExplosionVfx, collision.gameObject.transform.position, Quaternion.identity) as GameObject;
            Destroy(collision.gameObject);
            Destroy(explosion1, 5);
            
        }
    }
}
