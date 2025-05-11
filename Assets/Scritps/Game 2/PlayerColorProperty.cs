using UnityEngine;

public class PlayerColorProperty : ColorProperty
{
    private void OnEnable()
    {
        ColorPowerUpManager.OnChangueColor += SetUpColor;
    }


    private void OnDisable()
    {
        ColorPowerUpManager.OnChangueColor -= SetUpColor;
    }
}
