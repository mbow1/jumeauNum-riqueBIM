using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamEventOne : MonoBehaviour {

    public Camera[] cams;

    public void TeslabCameraSelect()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;


    }

    public void LumiereCameraSelect()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;
        cams[2].enabled = false;
        cams[3].enabled = false;
    }

    public void TuringCameraSelect()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = true;
        cams[3].enabled = false;
    }

    public void NobelCameraSelect()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = true;
    }
}
