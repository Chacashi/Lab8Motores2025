using System;
using UnityEngine;

public class ShapeObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData shapeData;
    private SpriteRenderer spriteRenderer;
    public static event Action<Sprite> OnChangueShape;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        SetUp();

    }
    private void SetUp()
    {
        spriteRenderer.sprite = shapeData.Sprite;
        spriteRenderer.color = shapeData.Color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnChangueShape?.Invoke(spriteRenderer.sprite);
        }
    }
}
