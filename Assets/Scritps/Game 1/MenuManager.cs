using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button buttonScene;
    [SerializeField] private Button buttonExit;
    [SerializeField] private string newScene;

    private void Start()
    {
        buttonExit.onClick.AddListener(Exit);
        buttonScene.onClick.AddListener(ChangueScene);
    }
    void Exit()
    {
        Application.Quit();
    
    }
    void ChangueScene()
    {
         SceneManager.LoadScene(newScene);
    }
}
