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
            myAge = 16;
            myHeight = 71; //inches
            myWeight = 150; //I dont really know my exact weight
            myEyes = "brown";
            myTeeth = "white";
            myHair = "black";

            Console.WriteLine("Let's talk about " + myName + ".");
            Console.WriteLine("He is " + myAge + " years old");
            Console.WriteLine("He's " + (myHeight) + + (myHeight * 2.54) + "cm tall.");
            Console.WriteLine("He weighs " + myWeight + " pounds or " + (myWeight / 2.2) + " kg heavy.");
            Console.WriteLine("He has " + myEyes + " eyes and " + myHair + " hair.");
            Console.WriteLine("and his teeth are pretty much " + myTeeth);

            Console.ReadLine();

            string name = "johnathan";
            Console.WriteLine(name);
            name = "jon";
            Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine();

            int myNumber = 15;
            myNumber = 20;
            Console.WriteLine(myNumber);

            Console.WriteLine();
            Console.WriteLine();

            double height = 1.62;
            Console.WriteLine(height);

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("The diference between int and double in a data type is");
            Console.WriteLine("that in is a 32 bit data type used to store and integer,");
            Console.WriteLine("and double is a 64 bit data type used to store flowting points");

            Console.WriteLine();
            Console.WriteLine();

            int age = 15;
            Console.WriteLine(age / 2);

            Console.ReadLine();
        }
    }
}
