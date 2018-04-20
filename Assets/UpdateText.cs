using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    Text logValue;

	// Use this for initialization
	void Start ()
	{
	    logValue = GetComponent<Text>();
	    //logValue.text = Inventory.logCount.ToString();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    logValue.text = "Pagaļu skaits: " + Inventory.logCount.ToString() + "/3";
	}
}
