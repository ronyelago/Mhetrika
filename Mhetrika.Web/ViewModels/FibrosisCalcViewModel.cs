using mhetrika.core.Entities;
using System;

namespace Mhetrika.Web.ViewModels
{
    public class FibrosisCalcViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Fibrosis Fibrosis { get; set; }
    }
}
