using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    [SerializeField] private string instructionPage = "InstructionsPage";
    [SerializeField] private string startPage = "StartPage";
    [SerializeField] private string mainPage = "MainGame";
    [SerializeField] private string resultPage = "ResultScreen";

    public void LoadInstructionsScene()
    {
        SceneManager.LoadScene(instructionPage);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(startPage);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(mainPage);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void EndGame()
    {
        SceneManager.LoadScene(resultPage);
    }
}