using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorPowerUpManager : MonoBehaviour
{
    [SerializeField] private ColorData[] colors;
    private int currentArrayColor =0;
   [SerializeField] private ColorData currentColor;
    private bool canChangeColor = true;
    public static event Action<ColorData> OnChangueColor;


    private void OnEnable()
    {
        Enemy.OnEnter += ValidateCollision;
        Enemy.OnExit += ReturnToNormal;
    }

    private void OnDisable()
    {
        Enemy.OnEnter -= ValidateCollision;
        Enemy.OnExit -= ReturnToNormal;
    }
    private void Start()
    {
       ChangueColorSelection();
    }
    public void OnPreviousColor(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            if (canChangeColor)
            {
                if (currentArrayColor > 0)
                {
                    currentArrayColor--;
                    ChangueColorSelection();
                }
                else
                {
                    currentArrayColor = colors.Length - 1;
                    ChangueColorSelection();
                }
            }
        }
      
        
    }

    public void OnNextColor(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if (canChangeColor)
            {
                if (currentArrayColor < colors.Length - 1)
                {
                    currentArrayColor++;
                    ChangueColorSelection();
                }
                else
                {
                    currentArrayColor = 0;
                    ChangueColorSelection();
                }
            }
        }
        
        
    }

    private void ChangueColorSelection()
    {
        currentColor = colors[currentArrayColor];
        OnChangueColor?.Invoke(currentColor);
    }

    private void ValidateCollision(ColorData otherColor, int damage)
    {
        canChangeColor = false;
        if(otherColor != currentColor)
        {
            GameManager.Instance.ModifyLife(-damage);
        }
       
    }

    private void ReturnToNormal()
    {
        canChangeColor = true;
    }
}
