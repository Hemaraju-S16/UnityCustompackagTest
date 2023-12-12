using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CustomToolkit
{
    public class MainCustomScriptManager
    {

        public int id;
        public string name;
        public Vector2 position;
        public Quaternion rotation;
        public GameObject prefab;

        public void Displayinfo()
        {
            Debug.Log("this is a class inside the maincustomScriptmanager" +  id  +  " and " + name);
        }
    }
}

