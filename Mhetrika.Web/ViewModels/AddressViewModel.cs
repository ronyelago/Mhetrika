using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mhetrika.Web.ViewModels
{
    public class AddressViewModel
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Máximo de 20 números")]
        [DisplayName("CEP")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cep { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Number { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        [DisplayName("Rua")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Street { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Neighbourhood { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string City { get; set; }

        [MaxLength(2, ErrorMessage = "Máximo de 2 caracteres")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "UF inválida")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Uf { get; set; }
    }
}
