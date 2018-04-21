using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTotalCount : MonoBehaviour {

    Text logValue;

    // Use this for initialization
    void Start () {
        logValue = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
	    logValue.text = "Kopējais skaits: " + Inventory.totalLogCount.ToString() + "/18";
    }
}
