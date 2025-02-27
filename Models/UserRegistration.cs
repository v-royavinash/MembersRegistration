//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MembersRegistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;


    public partial class UserRegistration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserRegistration()
        {
            this.ProfileCreations = new HashSet<ProfileCreation>();
            this.Relationships = new HashSet<Relationship>();
        }
    
        public long UserId { get; set; }

        [DisplayName("Username")]
        [StringLength(10)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "The field is required.")]
        
        public string UserName { get; set; }

        [DisplayName("Email id")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
       
        public string EmailId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The field is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 5)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [DataType(DataType.Password)]
        [DisplayName("ConfirmPassword")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileCreation> ProfileCreations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relationship> Relationships { get; set; }
    }
}
