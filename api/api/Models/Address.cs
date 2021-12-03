using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models {
    public class Address {
        [Key]
        public long id { get; set; }

        public string city { get; set; }
        public string street { get; set; }

        [Column("registry_number")]
        public int registryNumber { get; set; }

        [Column("building_number")]
        public int buildingNumber { get; set; }

        [Column("zip_code_id")]
        public long zipCodeId { get; set; }

        public ZipCode zipcode { get; set; }
    }
}
