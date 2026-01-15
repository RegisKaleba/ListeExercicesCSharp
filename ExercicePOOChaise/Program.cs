using ExercicePOOChaise.Classes;

Chaise chaise1 = new Chaise();
Chaise chaise2 = new Chaise(3, "Métal", "Noir");
Chaise chaise3 = new Chaise(4, "Plastique", "Blanc");

List<Chaise> chaises = new List<Chaise>
        {
            chaise1,
            chaise2,
            chaise3
        };

foreach (Chaise chaise in chaises)
{
    Console.WriteLine(chaise);
}