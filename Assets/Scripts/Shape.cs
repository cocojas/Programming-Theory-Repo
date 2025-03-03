using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string ShapeColor { get; protected set; } = "uncolored";
    public string ShapeName { get; protected set; } = "abstract";

    public abstract void DisplayText();

    public virtual string GetShapeDescription()
    {
        return $"{ShapeColor} {ShapeName}";
    }

    private void OnMouseDown()
    {
        DisplayText();       
    }
}
