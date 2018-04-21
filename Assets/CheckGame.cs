using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGame : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{


	}
	
	// Update is called once per frame
	void Update () {
        if (Inventory.totalLogCount == 0 && Inventory.logCount == 0 ) 
	    {
            Debug.Log("Quit!!!");
	        Application.Quit();
	    }
	}
}
