using UnityEngine;

[CreateAssetMenu(fileName = "ColorData", menuName = "Scriptable Objects/Game 2/ColorData", order = 1)]
public class ColorData : ScriptableObject
{
    [SerializeField] private Color color;

    public Color Color => color;    
}
