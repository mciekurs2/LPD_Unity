using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius = 3f;

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false;

    public virtual void Interact() //to overwrite..
    {
        Debug.Log("Interacting" + transform.name);
    }

    void Update()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            
            //vai player ir iekshaa radisuaa
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }

        }
    }

    public void OnFocused(Transform playersTransform)
    {
        isFocus = true;
        player = playersTransform;
        hasInteracted = false; //lai tikai vienu reizi interactotu
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }



}
