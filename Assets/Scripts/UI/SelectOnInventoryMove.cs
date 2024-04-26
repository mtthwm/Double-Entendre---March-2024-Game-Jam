using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectOnInventoryMove : MonoBehaviour
{
    [SerializeField] private InventoryView inventoryView;

    private void OnEnable()
    {
        inventoryView.OnInventoryShow += JustSelectAnyButtonImNotPicky;
    }
    private void OnDisable()
    {
        inventoryView.OnInventoryShow -= JustSelectAnyButtonImNotPicky;
    }

    private void JustSelectAnyButtonImNotPicky ()
    {
        foreach (InventoryButton invBtn in FindObjectsOfType<InventoryButton>())
        {
            Debug.Log(invBtn);
            Button btn = invBtn.gameObject.GetComponent<Button>();
            if (btn != null)
            {
                Debug.Log(btn);
                if (btn.enabled)
                {
                    btn.Select();
                    return;
                }
            }
        }
    }
}
