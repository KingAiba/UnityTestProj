using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightCycle : MonoBehaviour
{
    public enum Axis {X,Y,Z}

    public float speed = 100.0f;
    public float acceleration = 0.5f;
    public bool accelerationFlip = false;

    Vector3 angle;
    float rotation = 0f;

    public Axis axis = Axis.X;

    // Start is called before the first frame update
    void Start()
    {
        angle = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 600 || speed < 0)
        {
            accelerationFlip = !accelerationFlip;
        }

        if (accelerationFlip)
        {
            speed += acceleration;
        }
        else 
        {
            speed -= acceleration;
        }
        
        rotation += (speed)* Time.deltaTime;
        if (rotation >= 360f)
            rotation -= 360f;


        switch (axis)
        {
            case Axis.X:
                transform.localEulerAngles = new Vector3(rotation, angle.y, angle.z);
                break;
            case Axis.Y:
                transform.localEulerAngles = new Vector3(angle.x, rotation, angle.z);
                break;
            case Axis.Z:
                transform.localEulerAngles = new Vector3(angle.x, angle.y, rotation);
                break;
        }
    }
}
