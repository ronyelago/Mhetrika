using System;

namespace Mhetrika.Web.ViewModels
{
    public class DoctorViewModel
    {
        private DateTime creationDate;
        private DateTime modifiedDate;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Crm { get; set; }
        public string Uf { get; set; }
        public string Phone { get; set; }
        public string Specialty { get; set; }
        public DateTime CreationDate
        {
            get { return this.creationDate; }
            set { this.creationDate = DateTime.Now; }
        }
        public DateTime ModifiedDate
        {
            get { return this.modifiedDate; }
            set { this.modifiedDate = DateTime.Now; }
        }
    }
}
