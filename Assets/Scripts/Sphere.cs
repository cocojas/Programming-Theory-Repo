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
        string message = $"A {GetShapeDescription()}";
        popUpUI?.ShowPopUp(message);
        Debug.Log(message);
    }
}
