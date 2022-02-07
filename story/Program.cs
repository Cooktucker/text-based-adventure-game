using Newtonsoft.Json;
using story.Adventures;
using story.game;
using System;
using System.IO;
namespace Story
{
    class Program
    {
       private static GameService GameService = new GameService();

        static void Main(string[] args)
        {
            
            MakeTitle();
            MakeMainMenu();
            

        }

        private static void MakeMainMenu()
        {
            MenuOptions();
            Boolean inputValid = false;

            while (inputValid == false)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        GameService.StartGame();
                        inputValid = true;
                        break;
                    case "C":
                        CreateCharacter();
                        inputValid=true;
                        break;
                    case "L":
                        LoadGame();
                        inputValid=true;    
                        break;
                        
                    default:
                        Console.WriteLine("The input you used was not a correct option!");
                        MenuOptions();
                        inputValid = false;
                        break;
                }

            }


        }//end of main menu method

        private static void MenuOptions()
        {
            Console.WriteLine("(S)tart a new game.");
            Console.WriteLine("(L)oad a game.");
            Console.WriteLine("(C)reate a new character.");
        }

        private static void LoadGame()
        {
            Console.WriteLine("great job you loaded a game");
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("you are creating a character");
        }

        private static void MakeTitle()
        {
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("*  ______   __   __  __    _  _______  _______  _______  __    _                *");
            Console.WriteLine("* |      | |  | |  ||  |  | ||       ||       ||       ||  |  | |               *");
            Console.WriteLine("* |  _    ||  | |  ||   |_| ||    ___||    ___||   _   ||   |_| |               *");
            Console.WriteLine("* | | |   ||  |_|  ||       ||   | __ |   |___ |  | |  ||       |               *");
            Console.WriteLine("* | |_|   ||       ||  _    ||   ||  ||    ___||  |_|  ||  _    |               *");
            Console.WriteLine("* |       ||       || | |   ||   |_| ||   |___ |       || | |   |               *");
            Console.WriteLine("* |______| |_______||_|  |__||_______||_______||_______||_|  |__|               *");
            Console.WriteLine("* ______   _     _  _______  ___      ___      _______  ______    _______       *");
            Console.WriteLine("* |      | | | _ | ||       ||   |    |   |    |       ||    _ |  |       |     *");
            Console.WriteLine("* |  _    || || || ||    ___||   |    |   |    |    ___||   | ||  |  _____|     *");
            Console.WriteLine("* | | |   ||       ||   |___ |   |    |   |    |   |___ |   |_||_ | |_____      *");
            Console.WriteLine("* | |_|   ||       ||    ___||   |___ |   |___ |    ___||    __  ||_____  |     *");
            Console.WriteLine("* |       ||   _   ||   |___ |       ||       ||   |___ |   |  | | _____| |     *");
            Console.WriteLine("* |______| |__| |__||_______||_______||_______||_______||___|  |_||_______|     *");
            Console.WriteLine("********************************************************************************\n\n");
        }//end of titel method

        }
         



    }//create methods in front of this bracket
















