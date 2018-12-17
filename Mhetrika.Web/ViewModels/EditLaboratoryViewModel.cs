namespace Mhetrika.Web.ViewModels
{
    public class EditLaboratoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public AddressViewModel AddressViewModel { get; set; }
    }
}
