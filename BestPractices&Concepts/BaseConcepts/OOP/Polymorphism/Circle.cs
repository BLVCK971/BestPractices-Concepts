namespace BestPractices_Concepts.BaseConcepts.OOP.Polymorphism;

public class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}