
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HMSProject
{
  public class ApplicationUser : IdentityUser
  {

  }

  public enum Role
  {
    /// <summary>
    /// No Role
    /// </summary>
    [Display(Name = "No role")]
    None,
    /// <summary>
    /// Administrator
    /// </summary>
    [Display(Name = "Administrator")]
    Administrator,
    /// <summary>
    /// Nurse
    /// </summary>
    [Display(Name = "Nurse")]
    Nurse,
    /// <summary>
    /// Patient
    /// </summary>
    [Display(Name = "Patient")]
    Patient,
    /// <summary>
    /// Doctor
    /// </summary>
    [Display(Name = "Doctor")]
    Doctor
  }
}
