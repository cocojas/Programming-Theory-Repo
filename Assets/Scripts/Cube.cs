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
        string message = $"A {GetShapeDescription()}";
        popUpUI?.ShowPopUp(message);
    }
}
