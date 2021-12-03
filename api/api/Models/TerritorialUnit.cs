using System.ComponentModel.DataAnnotations;

namespace api.Models {
    public class TerritorialUnit {
        [Key]
        public long id { get; set; }

        public int uid { get; set; }
        public string name { get; set; }
    }
}
