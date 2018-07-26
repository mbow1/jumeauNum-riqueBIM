using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class FenetreUpdater
{     
    bool newetatfenetre = false;
    int id;

    internal FenetreUpdater(int pid)
    {
        id = pid;
    }

    private IEnumerator MetAJour()
    {
        
        WWW dataFromphp = new WWW("http://127.0.0.1/a/dataWindows.php");

        yield return dataFromphp;
        string dataFromphpstring = dataFromphp.text;

        //string dataFromphpstring = string.Empty;
        //DoRequest(out dataFromphpstring);
        string[] data = dataFromphpstring.Split(';');
        /*
        print(getDataValues(data[0], "id :"));
        print(getDataValues(data[0], "Time :"));
        print(getDataValues(data[0], "Etat :"));
        print(getDataValues(data[0], "Numero :"));
         */
        for (int i = 0; i <= 18; i++)
        {
            if (id.ToString() == getDataValues(data[i], "Numero :"))
            {
                if (getDataValues(data[0], "Etat :") == "0")
                    newetatfenetre = true;
                if (getDataValues(data[0], "Etat :") == "1")
                    newetatfenetre = false;
            }
        }
       
    }

    string getDataValues(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        value = value.Remove(value.IndexOf("|"));
        return value;
    }

    internal bool GetEtat()
    {
        MetAJour();
        return newetatfenetre;
    }
}

public class phpAunity : MonoBehaviour
{


    public int id;
    bool newetatfenetre;

    string[] data;
    // Use this for initialization
    FenetreUpdater updater;

    void Start()
    {
        WWW dataFromphp = new WWW("http://127.0.0.1/a/dataWindows.php");

        while(!dataFromphp.isDone)
            System.Threading.Thread.Sleep(1);
        //yield return dataFromphp;
        string dataFromphpstring = dataFromphp.text;
        data = dataFromphpstring.Split(';');
        /*
        print(getDataValues(data[0], "id :"));
        print(getDataValues(data[0], "Time :"));
        print(getDataValues(data[0], "Etat :"));
        print(getDataValues(data[0], "Numero :"));
         */
        for (int i = 0; i<data.Length-1; i++)
        {
            if (id.ToString() == getDataValues(data[i], "Numero :"))
            {
                if (getDataValues(data[0], "Etat :") == "0")
                    newetatfenetre = true;
                if (getDataValues(data[0], "Etat :") == "1")
                    newetatfenetre = false;
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
    void Update()
    {
        // newetatfenetre = updater.GetEtat();
        Start();

        this.GetComponent<TransformWindows>().EstOuvert = newetatfenetre;
       

    }
}
