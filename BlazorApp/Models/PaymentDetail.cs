using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        [StringLength(5, ErrorMessage = "Card Number need have 5 numbers.",MinimumLength = 5)]
        public string CardNumber { get; set; }

        //mm/yy
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        [StringLength(5, ErrorMessage = "Input date in format mm/yy", MinimumLength = 5)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/yy}")]
        public string ExpirationDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }
    }
}
