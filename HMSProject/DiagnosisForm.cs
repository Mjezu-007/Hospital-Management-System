using HMSProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;

namespace HMSProject
{
  public partial class DiagnosisForm : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<DoctorForm> _logger;
    private readonly AppDbContext _context;
    private readonly Home _home;

    public DiagnosisForm(ILogger<DoctorForm> logger
      , UserManager<ApplicationUser> userManager
      , AppDbContext context
      , Home home)
    {
      _logger = logger;
      _userManager = userManager;
      _context = context;
      _home = home;
      InitializeComponent();
    }

    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MJEZU PW\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

    void Populatecombo()
    {
      try
      {
        var dbPatients = _context.Patients.ToList();

        //Insert the Default Item to List.
        dbPatients.Insert(0, new Patient
        {
          Id = 0,
          Name = "Please select patient"
        });

        PatientIdCb.ValueMember = "Name";
        PatientIdCb.DataSource = dbPatients;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    string patname;

    void FecthPatientName()
    {
      var patientId = (PatientIdCb.SelectedItem as Patient)?.Id;

      var dbPatients = _context.Patients.Where(p => p.Id == patientId);
      foreach (var patient in dbPatients)
      {
        patname = patient.Name;
        PatientTb.Text = patname;
      }
    }

    void populate()
    {
      var dbDiagnosisSummaries = _context.DiagnosisSummaries;

      DiagnosisGV.DataSource = dbDiagnosisSummaries.ToList();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      _home.Show();
      this.Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (DiagId.Text == "" || SymptomsTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || MedicineTb.Text == "" || PatientTb.Text == "")
        MessageBox.Show("No Empty Fill Accepted");
      else
      {
        var diagnosisSumamryToAdd = new DiagnosisSummary
        {
          Diagnosis = DiagnosisTb.Text,
          Medicines = MedicineTb.Text,
          Symptoms = SymptomsTb.Text,
          PatientName = PatientTb.Text,
        };

        _context.DiagnosisSummaries.Add(diagnosisSumamryToAdd);
        _context.SaveChanges();

        MessageBox.Show("Diagnosis Successfully Added");
        populate();
      }
    }

    private void DiagnosisForm_Load(object sender, EventArgs e)
    {
      Populatecombo();
      populate();
    }

    private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
    {
      FecthPatientName();
    }

    private async void button3_Click(object sender, EventArgs e)
    {
      if (DiagId.Text == "")
        MessageBox.Show("Enter The Diagnosis Id");
      else
      {
        if (int.TryParse(DiagId.Text, out int id))
        {
          var dianosis = await _context.DiagnosisSummaries.FirstOrDefaultAsync(ds => ds.Id == id);
          if (dianosis == null)
          {
            MessageBox.Show($"Diagnosis with Id='{id}' does not exist.");
            return;
          }

          if (MessageBox.Show("This will delete a diagnosis from the database. Confirm?", "Delete Diagnosis", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            var diagnosisToRemove = _context.DiagnosisSummaries.Remove(dianosis);
            await _context.SaveChangesAsync();

            MessageBox.Show("Diagnosis Successfully Deleted");
            populate();
          }
          else
          {
            MessageBox.Show("Diagnosis ID must be an integer value!");
          }

        }
      }
    }

    private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DiagId.Text = DiagnosisGV.SelectedRows?[0].Cells?[0].Value.ToString();
      PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows?[0].Cells?[0].Value.ToString();
      PatientTb.Text = DiagnosisGV.SelectedRows?[0].Cells?[1].Value.ToString();
      SymptomsTb.Text = DiagnosisGV.SelectedRows?[0].Cells?[4].Value.ToString();
      DiagnosisTb.Text = DiagnosisGV.SelectedRows?[0].Cells?[3].Value.ToString();
      MedicineTb.Text = DiagnosisGV.SelectedRows?[0].Cells?[2].Value.ToString();

      PatientNamelbl.Text = DiagnosisGV.SelectedRows?[0].Cells?[1].Value.ToString();
      Diagnosislbl.Text = DiagnosisGV.SelectedRows?[0].Cells?[3].Value.ToString();
      Symptomslbl.Text = DiagnosisGV.SelectedRows?[0].Cells?[4].Value.ToString();
      medicineslbl.Text = DiagnosisGV.SelectedRows?[0].Cells?[2].Value.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        if (int.TryParse(DiagId.Text, out int id))
        {
          var diagnosis = _context.DiagnosisSummaries.Find(id);
          if (diagnosis == null)
          {
            MessageBox.Show($"Diagnosis with Id='{id}' does not exist.");
            return;
          }

          diagnosis.Diagnosis = DiagnosisTb.Text;
          diagnosis.Medicines = MedicineTb.Text;
          diagnosis.Symptoms = SymptomsTb.Text;
          diagnosis.PatientName = PatientTb.Text;

          var result = _context.DiagnosisSummaries.Update(diagnosis);
          _context.SaveChanges();

          MessageBox.Show("Diagnosis Successfully Updated");
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      populate();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
      {
        printDocument1.Print();
      }
    }

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {

    }

    private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(label4.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
      e.Graphics.DrawString(PatientNamelbl.Text + "\n" + Diagnosislbl.Text + "\n" + Symptomslbl.Text + "\n" + medicineslbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130, 150));
      e.Graphics.DrawString(label10.Text + "\n\t" + label11.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(230, 380));
    }

    private void label5_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void DiagId_OnValueChanged(object sender, EventArgs e)
    {

    }

    private void PatientTb_OnValueChanged(object sender, EventArgs e)
    {

    }

    private void PatientIdCb_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void medicineslbl_Click(object sender, EventArgs e)
    {

    }
  }
}