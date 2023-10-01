using SolidPrinciplesExample.OpenClosedPrinciple;
using SolidPrinciplesExample.Animal;


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


Console.WriteLine("\n\nInterface Segregation Principle:\n");

Console.WriteLine("Vanessa the dog creado");
Animal dog = new Dog("Vanessa the dog");
((Dog)dog).Run();

Animal yiguirro = new Yiguirro("Perry the yiguirro");
Console.WriteLine("Perry the yiguirro creado");
((Yiguirro) yiguirro).Fly();


Console.WriteLine("\n\nLiskov Substitution Principle:\n");

void AnimalEat(Animal animal)
{
    animal.Eat();
}


Console.WriteLine("Animal generico creado");
Animal cheetah = new Animal("Un animal generico");
AnimalEat(cheetah);

Console.WriteLine("");

Console.WriteLine("Jack the dog va creado");
dog = new Dog("Jack the dog");
AnimalEat(dog);


Console.WriteLine("\n\nDependency Inversion Principle:\n");

void AnimalsToEat(Animal[] animals)
{
    foreach (Animal x in animals)
    {
        x.Eat();
    }
}

Console.WriteLine("Se creo un Dog, un Turtle y un Yiguirro");

Animal[] animals = {
    new Turtle("Richard the turtle"),new Dog("Difo the dog"), new Yiguirro("Jake the yiguirro")
};
Console.WriteLine("Los tres animales van a comer");
AnimalsToEat(animals);
