using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactMgrWebModels
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="First Name Is Required")]
        [StringLength(ContactMgrConstants.Max_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Is Required")]
        [StringLength(ContactMgrConstants.Max_LAST_NAME_LENGTH)]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Address Is Required")]
        [StringLength(ContactMgrConstants.Max_EMAIL_LENGTH)]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Street Address Is Required")]
        [StringLength(ContactMgrConstants.Max_STREET_ADDRESS_LENGTH)]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City Is Required")]
        [StringLength(ContactMgrConstants.Max_CITY_LENGTH)]
        public string City { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Is Required")]
        [StringLength(ContactMgrConstants.Max_PHONE_LENGTH)]
        [Phone(ErrorMessage ="Invalid Phone Number")]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Zip Code Is Required")]
        [StringLength(ContactMgrConstants.Max_ZIP_CODE_LENGTH,MinimumLength =ContactMgrConstants.Min_ZIP_CODE_LENGTH)]
        [RegularExpression(@"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)", ErrorMessage = "That postal code is not a valid US or Canadian postal code.")]

        public string ZipCode { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State Is Required")]
        public int StateId { get; set; }

        // a navigation property
        public virtual State State { get; set; }

        [Required(ErrorMessage = "User ID Is Required")]
        public string UserId { get; set; }

        [Display(Name = "Full Name")]
        public string FriendlyName => $"{FirstName} {LastName}";

        //public string FriendlyAddress => State is null ? "" : string.IsNullOrWhiteSpace(StreetAddress)?


    }
}
