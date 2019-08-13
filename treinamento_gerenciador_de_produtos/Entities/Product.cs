
using System;

namespace treinamento_gerenciador_de_produtos.Entities
{
    class Product
    {
        //privates
        private float _price;
        //end of private

        //properties
        public ushort Id { get; private set; }
        public string Name { get; private set; }
        public ushort Quantity { get; private set; }
        //end of properties

        //contructor
        public Product(ushort id, string name)
        {
            Id = id;
            Name = name;
        }
        public Product(ushort id, string name, ushort quantity) : this(id, name)
        {
            Quantity = quantity;
        }
        public Product(ushort id, string name, ushort quantity, float price) : this(id, name, quantity)
        {
            _price = price;
        }
        //end of constructor

        //Custom prop
        public float Price
        {
            get { return _price; }
            set {
                if (_price + value < 0.00f)
                    Console.WriteLine("Erro 002: Product cannot have negative Price");
                else
                    _price += value;
                }

        }
        //end of custom

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
