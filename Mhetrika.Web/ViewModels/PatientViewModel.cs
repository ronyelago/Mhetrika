using LabClick.ViewModel.Validators;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mhetrika.Web.ViewModels
{
    public class PatientViewModel
    {
        private DateTime creationDate;
        private DateTime modifiedDate;

        [MaxLength(150, ErrorMessage = "Máximo de 150 caracteres")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        [DisplayName("Gênero")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Gender { get; set; }

        [DateValidator(ErrorMessage = "Data inválida")]
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime BirthDate { get; set; }

        [RegularExpression(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", ErrorMessage = "CPF inválido")]
        [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
        [DisplayName("CPF")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cpf { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [MaxLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Phone { get; set; }

        public DateTime CreationDate
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                this.creationDate = value;
            }
        }

        public DateTime ModifiedDate
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                this.modifiedDate = value;
            }
        }

        public AddressViewModel AddressViewModel { get; set; }
    }
}
