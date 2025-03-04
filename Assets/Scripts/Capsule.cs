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
        string message = $"An {GetShapeDescription()}";
        popUpUI?.ShowPopUp(message);
        Debug.Log(message);
    }
}
