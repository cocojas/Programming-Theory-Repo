using UnityEngine;

public class Cube : Shape
{
    private void Start()
    {
        ShapeColor = "blue";
        ShapeName = "cube";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        Debug.Log($"A {GetShapeDescription()}");
    }
}
