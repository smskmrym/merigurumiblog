using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace merigurumiblogFront.Models{
    public class BlogUpdateModel{
        public int Id { get; set; }
        public int AppUserId { get; set; }
        [Required(ErrorMessage="Lütfen başlık giriniz")]
        [Display(Name="Başlık")]
        public string Title {get; set;}
        [Required(ErrorMessage="Lütfen açıklama giriniz")]
        [Display(Name="Açıklama")]
        public string Description {get;set;}
        [Required(ErrorMessage="Lütfen Kısa Açıklama giriniz")]
        [Display(Name="Kısa Açıklama")]
        public string ShortDescription {get; set;}
        [Display(Name="Resim Seçiniz")]
        public IFormFile Image {get; set;}
    }
}