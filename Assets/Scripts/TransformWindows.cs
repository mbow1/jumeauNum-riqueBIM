using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformWindows : MonoBehaviour {

    /*
        public bool estOuvert = false;

        public float N_PositionX;
        public float N_PositionY;
        public float N_PositionZ;

        public float N_RotationX;
        public float N_RotationY;
        public float N_RotationZ;

        float A_PositionX = 0.0f;
        float A_PositionY = 0.0f;
        float A_PositionZ = 0.0f;

        float A_RotationX = 0.0f;
        float A_RotationY = 0.0f;
        float A_RotationZ = 0.0f;

        private void Start()
        {
            A_PositionX = transform.position.x;
            A_PositionY = transform.position.y;
            A_PositionZ = transform.position.z;

            A_RotationX = transform.eulerAngles.x;
            A_RotationY = transform.eulerAngles.y;
            A_RotationZ = transform.eulerAngles.z;
        }

        // Update is called once per frame
        void Update () {
            if (estOuvert)
            {
                transform.position = new Vector3(N_PositionX, N_PositionY, N_PositionZ);
                transform.eulerAngles = new Vector3(N_RotationX, N_RotationY, N_RotationZ);
            } else {
                transform.position = new Vector3(A_PositionX, A_PositionY, A_PositionZ);
                transform.eulerAngles = new Vector3(A_RotationX, A_PositionY, A_RotationZ);
            }
        }*/


    public bool EstOuvert { get; set; }
    public bool Gauche;
    //public bool Gauche { get; set; }


    float A_PositionX = 0.0f;
    float A_PositionY = 0.0f;
    float A_PositionZ = 0.0f;

    float A_RotationX = 0.0f;
    float A_RotationY = 0.0f;
    float A_RotationZ = 0.0f;


    private void Start()
    {

        A_PositionX = transform.position.x;
        A_PositionY = transform.position.y;
        A_PositionZ = transform.position.z;

        A_RotationX = transform.eulerAngles.x;
        A_RotationY = transform.eulerAngles.y;
        A_RotationZ = transform.eulerAngles.z;
        EstOuvert = false;
        Gauche = false;
    }

    void Update()
    {
        if (EstOuvert && !Gauche)
        {
            transform.eulerAngles = new Vector3(A_RotationX, A_RotationY - 45, A_RotationZ);
            transform.position = new Vector3(A_PositionX + 0.1f, A_PositionY, A_PositionZ - 0.3f);
        }
        else if (EstOuvert && Gauche)
        {
            transform.eulerAngles = new Vector3(A_RotationX, A_RotationY, A_RotationZ + 45);
            transform.position = new Vector3(A_PositionX - 0.1f, A_PositionY, A_PositionZ - 0.3f);
        } else 
        {
            transform.eulerAngles = new Vector3(A_RotationX, A_RotationY, A_RotationZ);
            transform.position = new Vector3(A_PositionX, A_PositionY, A_PositionZ);
        }
    }
}
