using TMPro;
using UnityEngine;

public class LifePanel : MonoBehaviour
{
    private TMP_Text life;

    private void Awake()
    {
        life = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        OnLifeUpdate(GameManager.Instance.PlayerLife);
    }
    private void OnEnable()
    {
        GameManager.OnLifeUpdate += OnLifeUpdate;
    }
    private void OnDisable()
    {
        GameManager.OnLifeUpdate -= OnLifeUpdate;
    }

    private void OnLifeUpdate(int life)
    {
        this.life.text = life.ToString();
    }
}
