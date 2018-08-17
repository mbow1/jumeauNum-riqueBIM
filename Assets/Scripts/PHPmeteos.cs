using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PHPmeteos : MonoBehaviour {
    public Text m_MyText ;
    public int id;
    string[] datam;
    string a;
    void Start()
    {
        WWW datafromphptem = new WWW("http://127.0.0.1/a/dataMeteos.php");
        while (!datafromphptem.isDone)
            System.Threading.Thread.Sleep(1);
        string dataString = datafromphptem.text;
        datam = dataString.Split(';');
        m_MyText = this.GetComponent<Text>();
            if (id == 0)
            {
                a = getDataValues(datam[0], "Time :");
                m_MyText.text           = "Last Update :" + a;
            }
            if(id == 1)
            {
                a = getDataValues(datam[0], "VitesseVent :");
                m_MyText.text           = "VitesseVent :" + a;
            }
            if (id == 2)
            {
                a = getDataValues(datam[0], "DirectionVent :");
                m_MyText.text           = "DirectionVent :" + a;
            }
            if (id == 3)
            {
                a = getDataValues(datam[0], "Pression :");
                m_MyText.text               = "Pression:" + a;
                }
            if (id == 4)
            {
                m_MyText.text           = "Humidite:        " + getDataValues(datam[0], "Humidite :");
            }
            if (id == 5)
            {
            m_MyText.text               = "Point de Rosee:  " + getDataValues(datam[0], "PointRosee :");
                }
            if (id == 6)
            {
            m_MyText.text               = "Pyra_N:          " + getDataValues(datam[0], "Pyra_N :");
                }
            if (id == 7)
            {
                m_MyText.text           = "Pyra_E:          " + getDataValues(datam[0], "Pyra_E :");
            }
            if (id == 8)
            {
            m_MyText.text               = "Pyra_S :         " + getDataValues(datam[0], "Pyra_S :");
                }
            if (id == 9)
            {
                m_MyText.text           = "Pyra_O :         " + getDataValues(datam[0], "Pyra_O :");
            }
            if (id == 10)
            {
            m_MyText.text               = "Luxmetre:        " + getDataValues(datam[0], "Luxmetre :");
            }
            if (id == 11)
            {
                m_MyText.text            = "Temperature:    " + getDataValues(datam[0], "Temperature :");
            }
            

    }
    string getDataValues(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        value = value.Remove(value.IndexOf("|"));
        return value;
    }
    void Update()
    {

        wait(3600);
        Start();
        
    }

    IEnumerator wait(int temps)
    {
        yield return new WaitForSeconds(temps);
    }
}