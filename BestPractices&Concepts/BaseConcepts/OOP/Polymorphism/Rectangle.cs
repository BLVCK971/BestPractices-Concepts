namespace BestPractices_Concepts.BaseConcepts.OOP.Polymorphism;
public class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}