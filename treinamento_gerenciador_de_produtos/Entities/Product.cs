
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

        Product(ushort id, string name, ushort quantity)
        {
            Quantity = quantity;
        }
        //end of constructor

        //methods

        //end of methods

        //overrides
        //end of overrides
    }
}
