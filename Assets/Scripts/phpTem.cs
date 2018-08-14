using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class phpTem : MonoBehaviour {

    string[] datat;
    public int idLoc;
	// Use this for initialization
	void Start () {
        WWW datafromphptem = new WWW("http://127.0.0.1/a/dataTemperatures.php");
          while (!datafromphptem.isDone)
              System.Threading.Thread.Sleep(1);
          string dataString = datafromphptem.text;
          datat = dataString.Split(';');

        //print(getDataValues(datat[0], "Local :"));

        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        for (int i = 0; i < datat.Length-1; i++)
        {
            if (idLoc.ToString() == getDataValues(datat[i], "Local :"))
            {
                textmeshPro.SetText("Temperature :" + getDataValues(datat[i], "Temperature :") + "°C \n Hygro :" + getDataValues(datat[i], "Hygro :") + ".");
            }
        }
    }

    string getDataValues(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        value = value.Remove(value.IndexOf("|"));
        return value;
    }

    // Update is called once per frame
    void Update () {
        Start();
    }
}
