using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain
{
    public class User : BaseEntity
    {
       [Required]
       public string? userName { get; set; }
       [Required]
       public byte[]? password { get; set; }
       public byte[]? passwordKey { get; set; }
    }
}
