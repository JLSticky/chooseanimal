using System;
using System.Text.Json;



namespace petdoge
{
    public class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
              
                
                Console.WriteLine("What animal is this right here?");
                Console.WriteLine("Type either Dog Cat or Walrus");
                String Animal = Console.ReadLine();
                IAnimal currentAnimal;


                if (Animal == "Cat" || Animal == "cat")
                    currentAnimal = new Cat();

                else if (Animal == "Dog" || Animal == "dog")
                    currentAnimal = new dog();

                else if (Animal == "Walrus" || Animal == "walrus")
                    currentAnimal = new Walrus();
                else
                    currentAnimal = new bush();

                

               

                Console.WriteLine("What is the name of this " + Animal);
                string name = Console.ReadLine();
                currentAnimal.name = name;
                
                    
                Console.WriteLine();

                Console.WriteLine("How old is this " + Animal);
                int.TryParse(Console.ReadLine(), out int age);
                currentAnimal.age = age;


















                Console.WriteLine(" ");

                Console.WriteLine("Press spacebar to pet " + name + " the " + Animal);
                Console.ReadKey();

                Console.WriteLine(" ");

                currentAnimal.petthepet();

                Console.WriteLine(" ");

                Console.WriteLine("Press spacebar to feed " + name + " the " + Animal);
                Console.ReadKey();

                Console.WriteLine(" ");

                currentAnimal.feedthepet();

                Console.WriteLine(" ");

                Console.WriteLine("Press spacebar to walk " + name + " the " + Animal);
                Console.ReadKey();

                Console.WriteLine(" ");

                currentAnimal.walkthepet();
                Console.WriteLine();

                
                string jsonString;
                jsonString = JsonSerializer.Serialize(currentAnimal, currentAnimal.GetType());

                Console.WriteLine(jsonString);

            }

        }

        private static void petthepet()
        {
            throw new NotImplementedException();
        }

        private static void walkthepet()
        {
            throw new NotImplementedException();
        }

        private static void feedthepet()
        {
            throw new NotImplementedException();


        }
    }

    }
