using System;
using System.Collections.Generic;

namespace Project.Persistance.SQL.EFCore.SQLServer.Entities
{
    public partial class WheaterForecast
    {
        public DateTime? Date { get; set; }
        public decimal? TemperatureC { get; set; }
        public int Id { get; set; }
        public int? SummaryId { get; set; }

        public virtual Summaries Summary { get; set; }
    }
}
