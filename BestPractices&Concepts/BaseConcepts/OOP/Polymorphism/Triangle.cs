namespace BestPractices_Concepts.BaseConcepts.OOP.Polymorphism;
public class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }
}