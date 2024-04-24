
using BestPractices_Concepts.BaseConcepts.OOP.Abstraction;
using BestPractices_Concepts.BaseConcepts.OOP.Encapsulation;
using BestPractices_Concepts.BaseConcepts.OOP.Inheritance;
using BestPractices_Concepts.BaseConcepts.OOP.Polymorphism;
using BestPractices_Concepts.DesignPatterns.Factory;
using BestPractices_Concepts.DesignPatterns.Factory.Creators;

////////////////// Abstraction
AbsMotorVehicle vehicle = new RealCar();
RealCar realCar = new RealCar();
vehicle.Drive();
realCar.Drive();
// RealCar est vide
//////////////////


////////////////// Encapsulation
Airplane airplane = new();
Airport.Accept(airplane);
//Airport n'a aucune mention du type Airplane pourtant il peut le gérer 
//////////////////


////////////////// Inheritance
Car car = new(24)
{
    modele = "Renault"
};
car.test();
// Car est vide , tout vient de Vehicle
//////////////////



////////////////// Polymorphism
List<Shape> shapes =
[
    new Rectangle(),
    new Triangle(),
    new Circle()
];

foreach (Shape shape in shapes)
{
    shape.Draw();
}
//////////////////



////////////////// Factory

Client.ClientCode(new EIPCreator());

Console.WriteLine("");

Client.ClientCode(new ModBusCreator());

///// Ajout Entité
/// Ajout Sercos : IProtocol 
/// Ajout SercosCreator : ProtocolCreator
/// Utilisateur Client.ClidentCode(new SercosCreator());

///// Dépendances
/// Client ne connait que abstract ProtocolCreator
/// EIP et Modbus ne connaissent que IProtocol
/// ProtocolCreator ne connait que IProtocol
/// EIPCreator et ModBusCreator ne connaissent que IProtocol et ProtocolCreator
//////////////////




////////////////// Abstract Factory
