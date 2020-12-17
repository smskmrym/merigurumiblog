using System.ComponentModel.DataAnnotations;

namespace merigurumiblogFront.Models{
    public class CategoryUpdateModel{
        public int Id{get; set;}
        [Required(ErrorMessage="Lütfen kategori adını giriniz")]
        [Display(Name="Ad")]
        public string Name {get; set;}
    }
}