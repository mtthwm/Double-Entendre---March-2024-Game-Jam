using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnBridge : MonoBehaviour
{
    [SerializeField] InventoryManager inventoryManager;

    [YarnCommand("addItem")] 
    public void AddItem (string item)
    {
        inventoryManager.AddItem(item);
    }

    [YarnCommand("selfDestruct")]
    public void SelfDestruct ()
    {
        Destroy(gameObject);
    }

    [YarnCommand("startGuess")]
    public void StartGuess ()
    {
        LevelManager.Instance.SwitchView();
    }

    [YarnCommand("checkGuess")]
    public void CheckGuess ()
    {
        Debug.Log(LevelManager.Instance.Check());
    }
}
