
using System;

namespace treinamento_gerenciador_de_produtos.Entities
{
    class Product
    {
        //properties
        public ushort Id { get; private set; }
        public string Name { get; private set; }
        public ushort Quantity { get; set; }
        public float Price { get; set; }
        //end of properties

        //contructor
        Product(ushort id, string name)
        {
            Id = id;
            Name = name;
        }
        Product(ushort id, string name, ushort quantity) : this( id, name)
        {
            Quantity = quantity;
        }
        Product(ushort id, string name, ushort quantity, float price) : this(id, name, quantity)
        {
            Price = price;
        }
        //end of constructor

        //methods
        public void Add(ushort i)
        {
            Quantity += i;
        }
        public void Remove(ushort i)
        {
            if (i > Quantity)
                Console.WriteLine("Erro 001: Quantity cannot be negative");
            else
                Quantity -= i;
        }
        //end of methods

        //overrides
        public override string ToString()
        {
            return "Id: " +
                Id.ToString() +
                Environment.NewLine +
                "Name: " +
                Name +
                ". Quantity: " +
                Quantity.ToString() +
                Environment.NewLine +
                "Price: " +
                Price.ToString("F2");
        }
        //end of overrides
    }
}
