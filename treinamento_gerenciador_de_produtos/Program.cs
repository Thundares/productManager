using System;
using System.Collections.Generic;
using treinamento_gerenciador_de_produtos.Entities;

namespace treinamento_gerenciador_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables for the program loop
            bool working = true;
            List<Product> Lista = new List<Product>();
            ushort[] id = new ushort[1];
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
                Menu(); //Whats is going to be shown
                working = Control(Lista, id); //input from the user
                Console.Clear();
            }
            //end of program loop
        }
 
        static void Menu()
        {
            Console.WriteLine("Options: <add> <remove> <edit> <show> <show_all> <quit>");
        }

        static bool Control(List<Product> lista, ushort[] id)
        {
            string input = Console.ReadLine();
            if (input == Anwser.add.ToString())
            {
               // Console.WriteLine("caso add");
                Console.WriteLine("Type the Name of the Product(optional: Quantity and Price)");
                string[] input2 = Console.ReadLine().Split(" ");

                if (input2.Length == 3)
                        {
                            Product temp = new Product(id[0]++, input2[0], ushort.Parse(input2[1]), float.Parse(input2[2]));
                            lista.Add(temp);
                        }
                else if (input2.Length == 2)
                        {
                            Product temp = new Product(id[0]++, input2[0], ushort.Parse(input2[1]));
                            lista.Add(temp);
                        }
                else if (input2.Length == 1)
                    {
                        Product temp = new Product(id[0]++, input2[0]);
                        lista.Add(temp);
                        
                    }

            }
            else if (input == Anwser.remove.ToString())
            {
               // Console.WriteLine("caso remove");
                Console.WriteLine("Type the name of the Product to remove");
                string input2 = Console.ReadLine();
                Product temp = null;
                foreach(Product obj in lista)
                {
                    if(obj.Name == input2)
                    {
                        temp = obj;
                    }
                } 
                if(temp != null){
                    lista.Remove(temp);
                    Console.WriteLine("Product was removed successfully");
                    Console.Read();
                }
            }
            else if (input == Anwser.edit.ToString())
            {
                Console.WriteLine("caso edit");
            }
            else if (input == Anwser.show.ToString())
            {
             //   Console.WriteLine("caso show");
                Console.WriteLine("Type the name of the Product to show");
                string input2 = Console.ReadLine();

                foreach(Product obj in lista)
                    if(obj.Name == input2)
                    {
                        Console.WriteLine(obj);
                    }
                Console.Read();
            }

            else if (input == Anwser.show_all.ToString())
            {
               // Console.WriteLine("caso show all");
                foreach(Product o in lista)
                    Console.WriteLine(o);
                Console.ReadLine();
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