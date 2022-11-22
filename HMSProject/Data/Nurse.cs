using System.ComponentModel;

namespace HMSProject.Data
{
  public class Nurse
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
