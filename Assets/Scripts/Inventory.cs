using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    #region Singleton


    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Error");
            return;
        }
        instance = this;
    }
    #endregion


    public int space = 3;

    public List<Item> items = new List<Item>();

    public static int logCount = 0;




    public bool Add(Item item)
    {
        //logCount = items.Count;
        //items.Add(item);

        

        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Nav pietiekami daudz vietas");
                return false;
            }

            logCount++;
            items.Add(item);
            
        }

        return true;

    }

    public bool Remove(Item item)
    {

        if (items.Count <= 0)
        {
            Debug.Log("Vairāk nav malkas");
            return false;
        }

        Debug.Log("Pievienota malka " + item.name);
        logCount--;
        items.Remove(item);

        return true;
    }

}
