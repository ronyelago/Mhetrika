namespace mhetrika.core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Neighbourhood { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
    }
}
