using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models
{
    public class AuditableEntity //: IAuditableEntity Тут наверное какой-то другой класс или создать именно его?
    {
        [Column("id", Order = 0)]
        [Key]
        public long Id { get; set; }

        [Column("created_by", Order = 101)]
        [MaxLength(256)]
        public string CreatedBy { get; set; }

        [Column("updated_by", Order = 103)]
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [Column("created_at", TypeName = "timestamp without time zone", Order = 102)]
        public DateTime CreatedDate { get; set; }

        [Column("updated_at", TypeName = "timestamp without time zone", Order = 104)]
        public DateTime UpdatedDate { get; set; }

    }
}
