using TMPro;
using UnityEngine;

public class CoinPanel : MonoBehaviour
{
    private TMP_Text coins;

    private void Awake()
    {
        coins = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        OnCoinsUpdate(GameManager.Instance.PlayerCoins);
    }
    private void OnEnable()
    {
        GameManager.OnCoinUpdate += OnCoinsUpdate;
    }
    private void OnDisable()
    {
        GameManager.OnCoinUpdate -= OnCoinsUpdate;
    }

    private void OnCoinsUpdate(int coins)
    {
        this.coins.text = coins.ToString();
    }
}
