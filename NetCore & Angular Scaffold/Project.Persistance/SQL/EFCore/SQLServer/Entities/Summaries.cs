using System;
using System.Collections.Generic;

namespace Project.Persistance.SQL.EFCore.SQLServer.Entities
{
    public partial class Summaries
    {
        public Summaries()
        {
            WheaterForecast = new HashSet<WheaterForecast>();
        }

        public int Id { get; set; }
        public string Summary { get; set; }

        public virtual ICollection<WheaterForecast> WheaterForecast { get; set; }
    }
}
