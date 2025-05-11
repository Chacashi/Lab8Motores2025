using System;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private int playerLife;
    private int maxLife;
    [SerializeField] private int playerCoins;
    public static event Action<int> OnLifeUpdate;
    public static event Action<int> OnCoinUpdate;
    public static event Action OnWin;
    public static event Action OnLoose;

    public int PlayerCoins => playerCoins;
    public int PlayerLife => playerLife;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
            Instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
    private void Start()
    {
        maxLife = playerLife;
        playerCoins = 0;
    }

    private void Update()
    {
        ValidateLife();
        CheckWin();
    }

    public void GainCoin()
    {
        playerCoins++;
        OnCoinUpdate?.Invoke(playerCoins);
    }

    public void ModifyLife(int modify)
    {

        playerLife += modify;
        
        if (PlayerLife > maxLife)
        {
            playerLife = maxLife;
        }
        OnLifeUpdate?.Invoke(playerLife);

    }

    public void CheckWin()
    {
        if (playerCoins >= 10)
        {
            OnWin?.Invoke();
            return;
        }
    }

    private void ValidateLife()
    {
        if (playerLife <= 0)
        {
            OnLoose?.Invoke();
            return;
        }
    }
}
