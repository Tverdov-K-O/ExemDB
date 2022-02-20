namespace ConsoleApp3.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Poduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poduct()
        {
            Pivots = new HashSet<Pivot>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public Guid CategoryId { get; set; }

        public Guid VenderId { get; set; }

        public Guid QualityId { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pivot> Pivots { get; set; }

        public virtual Quality Quality { get; set; }

        public virtual Vender Vender { get; set; }
    }
}
