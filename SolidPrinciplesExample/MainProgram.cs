using SolidPrinciplesExample.OpenClosedPrinciple;

Console.WriteLine("Open closed principle:\n");


Shape[] shapes = {
    new Rectangle
    {
        Height = 2,
        Width = 1
    },new Circle
    {
        Radius = 2,
    } 
};

Console.WriteLine("Creado un rectangulo de 2x1");
Console.WriteLine("Creado un circulo de radio 2");

AreaCalculator areaCalculator = new AreaCalculator();
double totalArea = areaCalculator.TotalArea(shapes);
Console.WriteLine($"El area total sumando las dos figuras es: {totalArea}");
Console.WriteLine("");


Rectangle rectangle = new Rectangle
{
    Height = 3,
    Width = 4
};
Console.WriteLine("Creado un rectangulo de 3x4");
Console.WriteLine($"La hipotenusa del rectangulo es: {rectangle.getHypotenuse()}");


Circle circle = new Circle
{
    Radius = 4,
};
Console.WriteLine("Creado un circulo de radio 4");
Console.WriteLine($"El diametro del circulo es: {circle.getDiameter()}");


Console.WriteLine("\n\nSingle responsability principle:");

