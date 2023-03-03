using System.ComponentModel.DataAnnotations;
 
namespace ContactMgrWebModels
{
    internal class State
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="State")]
        [Required(ErrorMessage = "Name of State is Required")]
        [StringLength(ContactMgrConstants.Max_STATE_NAME_LENGTH)]
        public String Name { get; set; }

        [StringLength(ContactMgrConstants.Max_STATE_ABBR_LENGTH)]
        [Required(ErrorMessage = "State Abbrevation is Required")]
        public String Abbreviation { get; set; }
    }
}
