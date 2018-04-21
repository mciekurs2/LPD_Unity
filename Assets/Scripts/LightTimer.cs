using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTimer : MonoBehaviour
{

    public Light light;
    public Item item;

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(Example());
	    light = GetComponent<Light>();
    }

    IEnumerator Example()
    {
        while (light.intensity != 0f) 
        {

            light.intensity -= .005f;
            yield return new WaitForSeconds(0.5f);
        }
    
    }


}
