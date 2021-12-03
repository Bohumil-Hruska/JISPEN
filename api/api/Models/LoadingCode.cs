using System.ComponentModel.DataAnnotations;

namespace api.Models {
    public class LoadingCode {
        [Key]
        public long id { get; set; }

        public string uid { get; set; }
        public string name { get; set; }
    }
}
