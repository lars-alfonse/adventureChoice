using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Game
    {
        private string userInput;
        private void Introduction()
        {
            Console.WriteLine("Welcome to Adveneture Rock! \n You find youreself on a beach and the sun is setting soon. \n You see a cave, a small forest and some tide pools. Where would you like to go? \n (Choose tide pools, forest, or cave)");
            userInput = Console.ReadLine();
        }
        private void MoveOffTheBeach()
        {
            Introduction();
            switch (userInput)
            {
                case "forest":
                    MoveFromForest();
                    break;
                case "tide pools":
                    MoveFromTidePools();
                    break;
                case "cave":
                    MoveFromCave();
                    break;
                default:
                    Console.WriteLine("Choice not recognized. Please enter a suggested choice");
                    MoveOffTheBeach();
                    break;
            }
        }
        private void MoveToForest()
        {
            Console.WriteLine("You shuffle through the sand and make your way to the forest. \n You see a small hut in a clearing in the woods. \n Would you like to enter the house or continue? \n (house or continue)");
            userInput = Console.ReadLine();
        }
        private void MoveFromForest()
        {
            MoveToForest();
            switch (userInput)
            {
                case "house":
                    MoveFromHouse();
                    break;
                case "continue":
                    SunSets();
                    break;
                default:
                    Console.WriteLine("Choice not recognized. Please enter a suggested choice");
                    MoveFromForest();
                    break;
            }
        }
        private void MoveToTidePools()
        {
            Console.WriteLine("As you approach the tide pools you see that they contain small fish that appear to be edible. \n You also notice some debris floating several hundred feet out. You decide that you can either swim out to investigate the debris or catch and cook the fish.\n What would you do? \n (swim or cook)");
            userInput = Console.ReadLine();
        }
        private void MoveFromTidePools()
        {
            MoveToTidePools();
            switch (userInput)
            {
                case "swim":
                    Console.WriteLine("You begin to swim out to the wreckage in the distance. \n You begin to tire. After a few minutes of swimming you reach the debris. \n You see what remains of a small vessel. You observe that it is still functional. \n You use the vessel to leave the island and return home. \n FIN");
                    Console.ReadLine();
                    break;
                case "cook":
                    Console.WriteLine("You easliy catch a few fish and cook them on a small fire. \n You feel that this is the best meal you have ever had. You decide to take the rest of the day to explore the beach\n");
                    SunSets();
                    break;
                default:
                    Console.WriteLine("Choice not recognized. Please enter a suggested choice");
                    MoveFromTidePools();
                    break;
            }
        }
        private void MoveToCave()
        {
            Console.WriteLine("As you enter the cave you notice a disticnt smell of garlic in the air. \n The Smell seems to grow stronger as you go further into the cave. \n After a few minuets of walking, the cave splits into two branching paths. \n Down the right path you can see light in the distance, the left path remains dark and the smell of garlic grows stronger. \n Which path will you take? (left or right) ");
            userInput = Console.ReadLine();
        }
        private void MoveFromCave()
        {
            MoveToCave();
            switch (userInput)
            {
                case "left":
                    Console.WriteLine("As you stumble through the dark the garlic smell grows stronger, eventually you discover its source. \n An old man stands over a pot boiling with water and garlic. He is startled by your presence and and fires a crossbow at you. You are hit in the chest and die");
                    Console.ReadLine();
                    break;
                case "right":
                    Console.WriteLine("As you follow the path to the right, you notice that the light is coming from an exit to the cave. \n You leave the cave and find a small clearing. You investigate further.");
                    SunSets();
                    break;
                default:
                    Console.WriteLine("Choice not recognized. Please enter a suggested choice");
                    MoveFromCave();
                    break;
            }
        }
        private void MoveToHouse()
        {
            Console.WriteLine("You approach the house and knock on the door. \n The door opens and what appears to be a sentient tree is standing before you. \n The tree seems to be a nice individual and invites you inside. You accept the tree's offer and come in for a spot of tea. \n The tea is heated by a wood stove which seems strange to you, but not as strange as the tree's proposition. \n The tree request that you stay and marry them: Do you say yes or no?");
            userInput = Console.ReadLine();
        }
        private void MoveFromHouse()
        {
            MoveToHouse();
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("You and the tree get married and have a nice time. The tree informs you that they have a disease that will kill them soon. \n They request that you use them as a raft and leave the island. \n The tree dies and you use the tree as a raft and make your escape. You return home to your family. You tell them nothing");
                    Console.WriteLine("FIN");
                    Console.ReadLine();
                    break;
                case "no":
                    Console.WriteLine("'I just met you' you say and you decline the tree's offer. \n You figure it would be awkward to stay so you make like a baby and head out.");
                    SunSets();
                    break;
                default:
                    Console.WriteLine("Choice not recognized. Please enter a suggested choice");
                    MoveFromHouse();
                    break;
            }
        }
        private void SunSets()
        {
            Console.WriteLine("As you continue exploring you notice the sun setting and darkness creep over the island. \n You begin to hear shreiks in the distance. \n You run. \n While running you feel your feet leave the ground. \n You are carried off into the night by vampires. You die.");
            Console.WriteLine("FIN");
            Console.ReadLine();
        }
        public void StartGame()
        {
            MoveOffTheBeach();
        }
    }         
}
