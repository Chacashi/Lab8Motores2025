using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    private Image ColorImage;

    private void Awake()
    {
        ColorImage = GetComponent<Image>();
    }

    private void OnEnable()
    {
        ColorObject.OnChangueColor += UpdateColor;
    }

    private void OnDisable()
    {
        ColorObject.OnChangueColor -= UpdateColor;
    }

    private void UpdateColor(Color newColor)
    {
        ColorImage.color = newColor;
    }

}
