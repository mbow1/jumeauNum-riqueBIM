using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsRotate : MonoBehaviour {
    public float RotateX = 0;
    public float RotateY = 0;
    public float RotateZ = 0;

    public bool estFrermer = false;



    public float NRotateX;
    public float NRotateY;
    public float NRotateZ;


    // Use this for initialization
    void Start () {
        Vector3 Mangle = transform.eulerAngles;
	}
	


	// Update is called once per frame
	void Update () {
		if (estFrermer)
        {
            transform.eulerAngles = new Vector3(NRotateX, NRotateY, NRotateZ);
        }else
        {
            //transform.eulerAngles = Mangle;
        }
	}
}
