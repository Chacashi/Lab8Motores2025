using System;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
 [SerializeField] private ColorShapeData colorData;
  private SpriteRenderer spriteRenderer;
  public static event Action<Color> OnChangueColor;

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
        spriteRenderer.color = colorData.Color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            OnChangueColor?.Invoke(spriteRenderer.color);
            
        }
    }
}
