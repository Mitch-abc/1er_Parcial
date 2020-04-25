

namespace _1er_Parcial.Models
{

    using System.ComponentModel.DataAnnotations;
    public enum TypeList
    {
        Colegio,
        Cafe,
        Plaza,
        Zoologico,
        stadium
    }
    public class Panozo

    {

        [Key]
        public int PanozoID { get; set; }
        [Required]
        [Display(nameof="Nombre Completo")]
        [StringLength(50, MunimunLength=5)]
        public string FriendofPanozo { get; set; }
       
        public  TypeList Place { get; set; }
        [Required]
        public string Email { get; set; }
        public int Birthday { get; set; }
    }
}