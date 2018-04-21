using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{

    public int newValue;
    public int oldValue;

	// Use this for initialization
	void Start ()
	{
	    oldValue = newValue;
	    
	}
	
	// Update is called once per frame
	void Update ()
	{

	    newValue = Inventory.totalLogCount;
        if (oldValue != newValue)
	    {
	        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + 5.0f,
	            transform.localEulerAngles.y, transform.localEulerAngles.z);

            Debug.Log("Izmaiņas in totalValue!!");

            oldValue = newValue;
	    }
    }
}
