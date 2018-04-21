using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFireIntensity : Interactable
{
    public Item item;
    public Light light;


    void Start()
    {
        light = GetComponent<Light>();
    }

    public override void Interact()
    {
        base.Interact();

        AddFuel();

    }

    void AddFuel()
    {

        bool removeItem = Inventory.instance.Remove(item);

        if (removeItem)

            //pievieno light intensity
            light.intensity += 0.1f;

            Debug.Log("Malka pievienota veiksmīgi!");
        }
            



    }
