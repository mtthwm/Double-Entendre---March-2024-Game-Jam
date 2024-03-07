using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueInventoryBridge : MonoBehaviour
{
    [SerializeField] InventoryManager inventoryManager;

    [YarnCommand("addItem")] 
    public void AddItem (string item)
    {
        inventoryManager.AddItem(item);
    }
}
