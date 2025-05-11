using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StateControll : MonoBehaviour
{
    [SerializeField] private Image panelWin;


    private void OnEnable()
    {
        GameManager.OnWin += Win;
    }

    private void OnDisable()
    {
        GameManager.OnWin -= Win;
    }
    private void Win()
    {
        Time.timeScale = 0;
        panelWin.gameObject.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {

            GameManager.Instance.ResetGame();
            SceneManager.LoadScene("Game 2");
            
        }
    }
}
