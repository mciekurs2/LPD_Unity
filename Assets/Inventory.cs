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

    public delegate void OnItemChanged();

    public OnItemChanged OnItemChangedCallBack;

    public int space = 3;

    public List<Item> items = new List<Item>();

    public bool Add(Item item)
    {
        //items.Add(item);

        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Nav pietiekami daudz vietas");
                return false;
            }
            items.Add(item);

            if (OnItemChangedCallBack != null)
            {
                OnItemChangedCallBack.Invoke();
            }
            
        }

        return true;

    }

    public void Remove(Item item)
    {
        Debug.Log("Pievienots invenory" + item.name);
        items.Remove(item);

        if (OnItemChangedCallBack != null)
        {
            OnItemChangedCallBack.Invoke();
        }

    }


}
