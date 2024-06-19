using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.DAL.Core
{
    public abstract class BaseEntity
    {
        //public string? CategoryName { get; set; }
        //public string? Description { get; set; }
        [Column("creation_date")]
        public DateTime CreationDate { get; set; }

        [Column("creation_user")]
        public int CreationUser { get; set; }

        [Column("modify_date")]
        public DateTime? ModifyDate { get; set; }

        [Column("modify_user")]
        public int? ModifyUser { get; set; }

        [Column("delete_user")]
        public int? DeleteUser { get; set; }

        [Column("delete_date")]
        public DateTime? DeleteDate { get; set; }

        [Column("deleted")]
        public bool Deleted { get; set; }
    }
}
