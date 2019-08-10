using System;
using treinamento_gerenciador_de_produtos.Entities;

namespace treinamento_gerenciador_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables for the program loop
            bool working = true;
            //end of the declaration

            //introduction
            Console.WriteLine("Welcome to the Product Manager 1.0");
            Console.WriteLine("Made by Thundares(R.K.Mippo)");
            Console.WriteLine("//==============================//");
            Console.WriteLine();
            //end of the introduction

            //program loop
            while (working)
            {
                Menu();
                working = Control();
            }
            //end of program loop
        }

        static void Menu()
        {
            Console.WriteLine("Options: <add> <remove> <edit> <show> <show_all> <quit>");
        }

        static bool Control()
        {
            string input = Console.ReadLine();
            if (input == Anwser.add.ToString())
            {
                Console.WriteLine("caso add");
            }
            else if (input == Anwser.remove.ToString())
            {
                Console.WriteLine("caso remove");
            }
            else if (input == Anwser.edit.ToString())
            {
                Console.WriteLine("caso edit");
            }
            else if (input == Anwser.show.ToString())
            {
                Console.WriteLine("caso show");
            }
            else if (input == Anwser.show_all.ToString())
            {
                Console.WriteLine("caso show all");
            }
            else if (input == Anwser.quit.ToString())
            {
                return false;
            }
            else
            {
                Console.Write("<{0}> is not a operational function.", input);
                Console.WriteLine("To leave this programm type <quit>");
            }
            return true;
        }
    }
}

