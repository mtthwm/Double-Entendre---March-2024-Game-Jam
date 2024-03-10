using UnityEngine;
using UnityEngine.SceneManagement;
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
    public static void StartGuess ()
    {
        LevelManager.Instance.SwitchView();
    }

    [YarnFunction("checkGuess")]
    public static bool CheckGuess ()
    {
        return LevelManager.Instance.Check();
    }

    [YarnCommand("loadScene")]
    public static void LoadScene (string name)
    {
        SceneManager.LoadScene(name);
    }
}
