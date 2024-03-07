using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] string[] solution;
    [SerializeField] InventoryManager solutionInventoryManager;
    [SerializeField] GameObject gameplayView;
    [SerializeField] GameObject mangaView;

    public static LevelManager Instance;

    private bool _inGameplayView = false;

    private void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        } else
        {
            Instance = this;
        }

        SwitchView();
    }

    public bool Check ()
    {
        string[] response = solutionInventoryManager.GetItems();
        if (response.Length != solution.Length)
        {
            return false;
        }

        for (int i = 0; i < response.Length; i++)
        {
            if (!response[i].Equals(solution[i]))
            {
                return false;
            }
        }

        return true;
    }

    public void SwitchView ()
    {
        _inGameplayView = !_inGameplayView;
        gameplayView.SetActive(false);
        mangaView.SetActive(false);

        if (_inGameplayView)
        {
            gameplayView.SetActive(true);
        } else
        {
            mangaView.SetActive(true);
        }
    }

}
