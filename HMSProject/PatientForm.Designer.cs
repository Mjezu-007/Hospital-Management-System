namespace HMSProject
{
  partial class PatientForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.PatId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.PatName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.PatDoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.PatPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.PatAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.GenderCb = new System.Windows.Forms.ComboBox();
      this.BloodCb = new System.Windows.Forms.ComboBox();
      this.MajorTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.PatientGV = new Guna.UI2.WinForms.Guna2DataGridView();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGreen;
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1376, 106);
      this.panel1.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.Red;
      this.label5.Location = new System.Drawing.Point(1193, 24);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(30, 29);
      this.label5.TabIndex = 12;
      this.label5.Text = "X";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label2.Location = new System.Drawing.Point(578, 62);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(137, 33);
      this.label2.TabIndex = 2;
      this.label2.Text = "PATIENT";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label1.Location = new System.Drawing.Point(358, 24);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(500, 33);
      this.label1.TabIndex = 1;
      this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
      // 
      // PatId
      // 
      this.PatId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.PatId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.PatId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.PatId.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.PatId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PatId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatId.HintText = "Patient ID";
      this.PatId.isPassword = false;
      this.PatId.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.PatId.LineIdleColor = System.Drawing.Color.Gray;
      this.PatId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.PatId.LineThickness = 3;
      this.PatId.Location = new System.Drawing.Point(37, 134);
      this.PatId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.PatId.MaxLength = 32767;
      this.PatId.Name = "PatId";
      this.PatId.Size = new System.Drawing.Size(172, 35);
      this.PatId.TabIndex = 2;
      this.PatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.PatId.OnValueChanged += new System.EventHandler(this.PatId_OnValueChanged);
      // 
      // PatName
      // 
      this.PatName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.PatName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.PatName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.PatName.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.PatName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatName.HintText = "Patient Name";
      this.PatName.isPassword = false;
      this.PatName.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.PatName.LineIdleColor = System.Drawing.Color.Gray;
      this.PatName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.PatName.LineThickness = 3;
      this.PatName.Location = new System.Drawing.Point(37, 187);
      this.PatName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.PatName.MaxLength = 32767;
      this.PatName.Name = "PatName";
      this.PatName.Size = new System.Drawing.Size(172, 35);
      this.PatName.TabIndex = 3;
      this.PatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // PatDoc
      // 
      this.PatDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.PatDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.PatDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.PatDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.PatDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PatDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatDoc.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatDoc.HintText = "Patient Doctor";
      this.PatDoc.isPassword = false;
      this.PatDoc.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.PatDoc.LineIdleColor = System.Drawing.Color.Gray;
      this.PatDoc.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.PatDoc.LineThickness = 3;
      this.PatDoc.Location = new System.Drawing.Point(37, 239);
      this.PatDoc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.PatDoc.MaxLength = 32767;
      this.PatDoc.Name = "PatDoc";
      this.PatDoc.Size = new System.Drawing.Size(172, 35);
      this.PatDoc.TabIndex = 4;
      this.PatDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.PatDoc.OnValueChanged += new System.EventHandler(this.PatDoc_OnValueChanged);
      // 
      // PatPhone
      // 
      this.PatPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.PatPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.PatPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.PatPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.PatPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PatPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatPhone.HintForeColor = System.Drawing.Color.Empty;
      this.PatPhone.HintText = "Patient Phone No.";
      this.PatPhone.isPassword = false;
      this.PatPhone.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.PatPhone.LineIdleColor = System.Drawing.Color.Gray;
      this.PatPhone.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.PatPhone.LineThickness = 3;
      this.PatPhone.Location = new System.Drawing.Point(37, 292);
      this.PatPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.PatPhone.MaxLength = 32767;
      this.PatPhone.Name = "PatPhone";
      this.PatPhone.Size = new System.Drawing.Size(172, 35);
      this.PatPhone.TabIndex = 5;
      this.PatPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // PatAge
      // 
      this.PatAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.PatAge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.PatAge.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.PatAge.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.PatAge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PatAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatAge.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.PatAge.HintText = "Patient Age";
      this.PatAge.isPassword = false;
      this.PatAge.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.PatAge.LineIdleColor = System.Drawing.Color.Gray;
      this.PatAge.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.PatAge.LineThickness = 3;
      this.PatAge.Location = new System.Drawing.Point(37, 344);
      this.PatAge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.PatAge.MaxLength = 32767;
      this.PatAge.Name = "PatAge";
      this.PatAge.Size = new System.Drawing.Size(172, 35);
      this.PatAge.TabIndex = 6;
      this.PatAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.PatAge.OnValueChanged += new System.EventHandler(this.PatAge_OnValueChanged);
      // 
      // GenderCb
      // 
      this.GenderCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.GenderCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.GenderCb.FormattingEnabled = true;
      this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
      this.GenderCb.Location = new System.Drawing.Point(37, 395);
      this.GenderCb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.GenderCb.Name = "GenderCb";
      this.GenderCb.Size = new System.Drawing.Size(171, 25);
      this.GenderCb.TabIndex = 7;
      this.GenderCb.Text = "Gender";
      this.GenderCb.SelectedIndexChanged += new System.EventHandler(this.GenderCb_SelectedIndexChanged);
      // 
      // BloodCb
      // 
      this.BloodCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BloodCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BloodCb.FormattingEnabled = true;
      this.BloodCb.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
      this.BloodCb.Location = new System.Drawing.Point(37, 444);
      this.BloodCb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.BloodCb.Name = "BloodCb";
      this.BloodCb.Size = new System.Drawing.Size(171, 25);
      this.BloodCb.TabIndex = 8;
      this.BloodCb.Text = "BloodGroup";
      // 
      // MajorTb
      // 
      this.MajorTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.MajorTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.MajorTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.MajorTb.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.MajorTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.MajorTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.MajorTb.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.MajorTb.HintText = "Sickness";
      this.MajorTb.isPassword = false;
      this.MajorTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.MajorTb.LineIdleColor = System.Drawing.Color.Gray;
      this.MajorTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.MajorTb.LineThickness = 3;
      this.MajorTb.Location = new System.Drawing.Point(37, 485);
      this.MajorTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.MajorTb.MaxLength = 32767;
      this.MajorTb.Name = "MajorTb";
      this.MajorTb.Size = new System.Drawing.Size(172, 35);
      this.MajorTb.TabIndex = 9;
      this.MajorTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.DarkGreen;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.button4.Location = new System.Drawing.Point(100, 603);
      this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(108, 51);
      this.button4.TabIndex = 14;
      this.button4.Text = "Home";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.DarkGreen;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.button3.Location = new System.Drawing.Point(204, 546);
      this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(91, 51);
      this.button3.TabIndex = 13;
      this.button3.Text = "Delete";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.DarkGreen;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.button2.Location = new System.Drawing.Point(105, 546);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(92, 51);
      this.button2.TabIndex = 12;
      this.button2.Text = "Update";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.DarkGreen;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.button1.Location = new System.Drawing.Point(9, 546);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(89, 51);
      this.button1.TabIndex = 11;
      this.button1.Text = "Add";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.Purple;
      this.label3.Location = new System.Drawing.Point(645, 125);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(225, 33);
      this.label3.TabIndex = 15;
      this.label3.Text = "PATIENTS LIST";
      // 
      // PatientGV
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      this.PatientGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.PatientGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.PatientGV.ColumnHeadersHeight = 25;
      this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.PatientGV.DefaultCellStyle = dataGridViewCellStyle3;
      this.PatientGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      this.PatientGV.Location = new System.Drawing.Point(318, 166);
      this.PatientGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.PatientGV.Name = "PatientGV";
      this.PatientGV.RowHeadersVisible = false;
      this.PatientGV.RowTemplate.Height = 30;
      this.PatientGV.Size = new System.Drawing.Size(1028, 497);
      this.PatientGV.TabIndex = 16;
      this.PatientGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
      this.PatientGV.ThemeStyle.AlternatingRowsStyle.Font = null;
      this.PatientGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
      this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
      this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
      this.PatientGV.ThemeStyle.BackColor = System.Drawing.Color.White;
      this.PatientGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      this.PatientGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
      this.PatientGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.PatientGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PatientGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
      this.PatientGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
      this.PatientGV.ThemeStyle.HeaderStyle.Height = 25;
      this.PatientGV.ThemeStyle.ReadOnly = false;
      this.PatientGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
      this.PatientGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.PatientGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PatientGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      this.PatientGV.ThemeStyle.RowsStyle.Height = 30;
      this.PatientGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      this.PatientGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
      // 
      // PatientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gainsboro;
      this.ClientSize = new System.Drawing.Size(1376, 689);
      this.Controls.Add(this.PatientGV);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.MajorTb);
      this.Controls.Add(this.BloodCb);
      this.Controls.Add(this.GenderCb);
      this.Controls.Add(this.PatAge);
      this.Controls.Add(this.PatPhone);
      this.Controls.Add(this.PatDoc);
      this.Controls.Add(this.PatName);
      this.Controls.Add(this.PatId);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "PatientForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PatientForm";
      this.Load += new System.EventHandler(this.PatientForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private Bunifu.Framework.UI.BunifuMaterialTextbox PatId;
    private Bunifu.Framework.UI.BunifuMaterialTextbox PatName;
    private Bunifu.Framework.UI.BunifuMaterialTextbox PatDoc;
    private Bunifu.Framework.UI.BunifuMaterialTextbox PatPhone;
    private Bunifu.Framework.UI.BunifuMaterialTextbox PatAge;
    private System.Windows.Forms.ComboBox GenderCb;
    private System.Windows.Forms.ComboBox BloodCb;
    private Bunifu.Framework.UI.BunifuMaterialTextbox MajorTb;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
    private Guna.UI2.WinForms.Guna2DataGridView PatientGV;
    private System.Windows.Forms.Label label5;
  }
}