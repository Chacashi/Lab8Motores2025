using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    private Image ShapeImage;

    private void Awake()
    {
        ShapeImage = GetComponent<Image>();
    }

    private void OnEnable()
    {
        ShapeObject.OnChangueShape += UpdateShape;
    }

    private void OnDisable()
    {
        ShapeObject.OnChangueShape -= UpdateShape;
    }

    private void UpdateShape(Sprite newSprite)
    {
        ShapeImage.sprite = newSprite;
    }
}
