using UnityEngine;

public class ColorProperty : MonoBehaviour
{
    [SerializeField] protected ColorData colorData;
    protected MeshRenderer meshRenderer;
    [SerializeField] protected Material material;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        meshRenderer.material = material;
        material.color = colorData.Color;
    }

    protected void SetUpColor(ColorData newColor)
    {
        meshRenderer.material.color = newColor.Color;   
    }
}
