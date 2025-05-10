using UnityEngine;
[CreateAssetMenu(fileName = "Color Shape Data", menuName = "Scriptable Objects/Game 1/ColorShapeData")]
public class ColorShapeData : ScriptableObject
{
    [SerializeField] private Color color;
    [SerializeField] private Sprite sprite;
    
    public Color Color => color;
    public Sprite Sprite => sprite;

}
