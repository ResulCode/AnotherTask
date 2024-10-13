namespace ClassHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object of Dog Class
            Dog userDog = new Dog();
            Console.Write("Enter your dog name:");
            userDog.name = Console.ReadLine();
            Console.Write("Enter your dog age:");
            userDog.age = Convert.ToByte(Console.ReadLine());
            Console.Write("Is your dog has a tail?(true or false)");
            userDog.hasTail = Convert.ToBoolean(Console.ReadLine());

            //Object of Bear Class
            Bear userBear = new Bear();
            Console.Write("Enter your bear name:");
            userBear.name = Console.ReadLine();
            Console.Write("Enter your bear age:");
            userBear.age = Convert.ToByte(Console.ReadLine());
            Console.Write("Is your bear wield?(true or false)");
            userBear.isWild = Convert.ToBoolean(Console.ReadLine());

            //Object of Bird Class
            Bird userBird = new Bird();
            Console.Write("Enter your bird name:");
            userBird.name = Console.ReadLine();
            Console.Write("Enter your bird age:");
            userBird.age = Convert.ToByte(Console.ReadLine());
            Console.Write("Is your bird can swim?(true or false)");
            userBird.canSwim = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine($"Your dog name is {userDog.name} and your dog age is {userDog.age}. Also dogs have tails is {userDog.hasTail}.{Dog.Bark()}{Animal.Eat()}");
            Console.WriteLine($"Your bear name is {userBear.name} and your bear age is {userBear.age}. Also bears are wild is {userBear.isWild}.{Animal.Eat()}");
            Console.WriteLine($"Your bird name is {userBird.name} and your bird age is {userBird.age}. Also birds can swim is {userBird.canSwim}.{Bird.CanFly()}{Animal.Eat()}");

        }
    }
    
}
