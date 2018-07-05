using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float minX = -45.0f;
    public float maxX = 45.0f;

    public float minY = -45.0f;
    public float maxY = 45.0f;

    public float sensX = 50f;
    public float sensY = 50f;

    public float rotationY = -61.1f;
    public float rotationX = 10.8f;

    void Update()
    {
       if ((rotationX <= maxX && rotationX >= minX)) {

              if (Input.GetKey(KeyCode.RightArrow) )
                {
                    rotationX += sensX * Time.deltaTime;
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rotationX -= sensX * Time.deltaTime;
                }
        } else
        {
            if (rotationX >= maxX)
            {
                rotationX -= 0.1f;
            } else
            {
                rotationX += 0.1f;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotationY += sensY * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotationY -= sensY * Time.deltaTime;
        }



        rotationY = Mathf.Clamp(rotationY, minY, maxY);
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
