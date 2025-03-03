using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
        ShapeColor = "orange";
        ShapeName = "capsule";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        Debug.Log($"An {GetShapeDescription()}");
    }
}
