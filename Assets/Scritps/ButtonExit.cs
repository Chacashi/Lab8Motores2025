using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    private Button buttonExit;

    private void Awake()
    {
        buttonExit = GetComponent<Button>();
    }
    private void Start()
    {
        buttonExit.onClick.AddListener(Exit);
    }
    void Exit()
    {
        Application.Quit();

    }
}
