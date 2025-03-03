using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        ShapeColor = "red";
        ShapeName = "sphere";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        Debug.Log($"A {GetShapeDescription()}");
    }
}
