using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class OneLightConfiguration
{
    public int RoomId;
    public int FixtureId;
}


public class LightMngr : MonoBehaviour {

    public OneLightConfiguration parameters;

    // Use this for initialization
    void Start () {
        SmartUdpCLient.LightManagement.Init();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    int Count=0;

    void OnMouseDown()
    {
        Count++;
        // this object was clicked - do something
        Debug.Log("Button click! - "+ Count);
        if(Count%2==0)
        { 
            Debug.Log(string.Format("Switch On {0}-{1}", parameters.RoomId, parameters.FixtureId));
            SmartUdpCLient.LightManagement.SwichOn(parameters.RoomId, parameters.FixtureId);
        }
        else
        {
            Debug.Log(string.Format("Switch Off {0}-{1}", parameters.RoomId, parameters.FixtureId));
            SmartUdpCLient.LightManagement.SwichOff(parameters.RoomId, parameters.FixtureId);
        }
            

         
    }
}
