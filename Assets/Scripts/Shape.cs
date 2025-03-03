using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public string ShapeColor { get; protected set; } = "uncolored";
    public string ShapeName { get; protected set; } = "abstract";

    // ABSTRACTION
    public abstract void DisplayText();

    // POLYMORPHISM
    public virtual string GetShapeDescription()
    {
        return $"{ShapeColor} {ShapeName}";
    }

    // INHERITANCE
    private void OnMouseDown()
    {
        DisplayText();       
    }
}
