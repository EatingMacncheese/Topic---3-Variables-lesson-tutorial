namespace Topic___3_Variables_lesson_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiago
            String myName, myEyes, myTeeth, myHair;
            int myAge, myHeight, myWeight;

            myName = "Tiago";
            myHeight = 71; //inches
            myWeight = 150; //I dont really know my exact weight
            myEyes = "brown";
            myTeeth = "white";
            myHair = "black";

            Console.WriteLine("Let's talk about " + myName + ".");
            Console.WriteLine("He's " + (myHeight) + " inches tall.");
            Console.WriteLine("he weighs " + myWeight + " pounds.");
            Console.WriteLine("he has" + myEyes + "eyes and " + myHair + " hair.");
            Console.WriteLine("his teeth are pretty much" + myTeeth);

            Console.ReadLine();

        }
    }
}
