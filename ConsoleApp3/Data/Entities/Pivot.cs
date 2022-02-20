namespace ConsoleApp3.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pivot")]
    public partial class Pivot
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ColorId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SizeId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid GenderId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Count { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Prise { get; set; }

        public virtual Color Color { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Poduct Poduct { get; set; }

        public virtual Size Size { get; set; }
    }
}
