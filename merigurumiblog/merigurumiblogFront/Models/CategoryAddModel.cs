using System.ComponentModel.DataAnnotations;

namespace merigurumiblogFront.Models{
    public class CategoryAddModel{
        [Required(ErrorMessage="Lütfen kategori adını giriniz")]
        [Display(Name="Ad")]
        public string Name {get; set;}
    }
}