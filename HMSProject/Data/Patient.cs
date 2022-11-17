using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HMSProject
{
  public class Patient
  {
    public int Id { get; set; }

    [Browsable(false)]
    public string? ApplicationUserId { get; set; }

    [Browsable(false)]
    public ApplicationUser ApplicationUser { get; set; }

    public string Name { get; set; }

    public string Doctor { get; set; }

    public int PhoneNumber { get; set; }

    public int Age { get; set; }

    public Gender Gender { get; set; }

    public BloodType BloodGroup { get; set; }

    public string Sickness { get; set; }
  }

  public enum Gender
  {
    Male = 0,
    Female = 1,
    PreferNotToSay = 2
  }

  public enum BloodType
  {
    [Display(Name = "A+")]
    APositive,
    [Display(Name = "O+")]
    OPositive,
    [Display(Name = "B+")]
    BPositive,
    [Display(Name = "AB+")]
    ABPositive,
    [Display(Name = "A-")]
    ANegative,
    [Display(Name = "O-")]
    ONegative,
    [Display(Name = "B-")]
    BNegative,
    [Display(Name = "AB-")]
    ABNegative,
  }
}
