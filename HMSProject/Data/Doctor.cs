using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMSProject
{
  public class Doctor
  {
    public int Id { get; set; }

    [Browsable(false)]
    public string? ApplicationUserId { get; set; }

    [Browsable(false)]
    public ApplicationUser ApplicationUser { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public int YearsOfExperience { get; set; }
  }
}
