using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persistance.EFCore.SQLServer.Entities
{
    public partial class Companies
    {
        [Key]
        public int IdCompany { get; set; }
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}
