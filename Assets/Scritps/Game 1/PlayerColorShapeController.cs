using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    [SerializeField] private ColorShapeData playerData;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        ColorObject.OnChangueColor += UpdateColor;
        ShapeObject.OnChangueShape += UpdateShape;
    }

    private void OnDisable()
    {
        ColorObject.OnChangueColor -= UpdateColor;
        ShapeObject.OnChangueShape -= UpdateShape;
    }
    private void Start()
    {
        SetUp();
    }
    private void SetUp()
    {
        UpdateColor(playerData.Color);
        UpdateShape(playerData.Sprite);
    }

    private void UpdateColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }


    private void UpdateShape(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }
}
