using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScene : MonoBehaviour
{
    private Button buttonScene;
    [SerializeField] private string newScene;

    private void Awake()
    {
        buttonScene = GetComponent<Button>();
    }

    private void Start()
    {
        buttonScene.onClick.AddListener(ChangueScene);
    }
    void ChangueScene()
    {
       
        SceneManager.LoadScene(newScene);
        GameManager.Instance.ResetGame();
    }
}
