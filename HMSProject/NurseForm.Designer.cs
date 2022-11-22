namespace HMSProject
{
  partial class NurseForm
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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.NurseSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.NursePass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.NurseExp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.NurseName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.NurseId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
      this.HomeButton = new System.Windows.Forms.Button();
      this.DeleteButton = new System.Windows.Forms.Button();
      this.UpdateButton = new System.Windows.Forms.Button();
      this.AddButton = new System.Windows.Forms.Button();
      this.NurseGV = new Guna.UI2.WinForms.Guna2DataGridView();
      this.label3 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NurseGV)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGreen;
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1260, 106);
      this.panel1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label2.Location = new System.Drawing.Point(568, 62);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(116, 33);
      this.label2.TabIndex = 2;
      this.label2.Text = "NURSE";
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
      // NurseSurname
      // 
      this.NurseSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.NurseSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.NurseSurname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.NurseSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.NurseSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NurseSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseSurname.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseSurname.HintText = "Nurse Surname";
      this.NurseSurname.isPassword = false;
      this.NurseSurname.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.NurseSurname.LineIdleColor = System.Drawing.Color.Gray;
      this.NurseSurname.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.NurseSurname.LineThickness = 3;
      this.NurseSurname.Location = new System.Drawing.Point(44, 288);
      this.NurseSurname.Margin = new System.Windows.Forms.Padding(5);
      this.NurseSurname.MaxLength = 32767;
      this.NurseSurname.Name = "NurseSurname";
      this.NurseSurname.Size = new System.Drawing.Size(172, 35);
      this.NurseSurname.TabIndex = 15;
      this.NurseSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // NursePass
      // 
      this.NursePass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.NursePass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.NursePass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.NursePass.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.NursePass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NursePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NursePass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NursePass.HintText = "Password";
      this.NursePass.isPassword = false;
      this.NursePass.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.NursePass.LineIdleColor = System.Drawing.Color.Gray;
      this.NursePass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.NursePass.LineThickness = 3;
      this.NursePass.Location = new System.Drawing.Point(44, 405);
      this.NursePass.Margin = new System.Windows.Forms.Padding(5);
      this.NursePass.MaxLength = 32767;
      this.NursePass.Name = "NursePass";
      this.NursePass.Size = new System.Drawing.Size(172, 35);
      this.NursePass.TabIndex = 14;
      this.NursePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // NurseExp
      // 
      this.NurseExp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.NurseExp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.NurseExp.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.NurseExp.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.NurseExp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NurseExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseExp.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseExp.HintText = "Years Of Experience";
      this.NurseExp.isPassword = false;
      this.NurseExp.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.NurseExp.LineIdleColor = System.Drawing.Color.Gray;
      this.NurseExp.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.NurseExp.LineThickness = 3;
      this.NurseExp.Location = new System.Drawing.Point(44, 348);
      this.NurseExp.Margin = new System.Windows.Forms.Padding(5);
      this.NurseExp.MaxLength = 32767;
      this.NurseExp.Name = "NurseExp";
      this.NurseExp.Size = new System.Drawing.Size(172, 35);
      this.NurseExp.TabIndex = 13;
      this.NurseExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // NurseName
      // 
      this.NurseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.NurseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.NurseName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.NurseName.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.NurseName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NurseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseName.HintText = "Name of Nurse";
      this.NurseName.isPassword = false;
      this.NurseName.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.NurseName.LineIdleColor = System.Drawing.Color.Gray;
      this.NurseName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.NurseName.LineThickness = 3;
      this.NurseName.Location = new System.Drawing.Point(44, 228);
      this.NurseName.Margin = new System.Windows.Forms.Padding(5);
      this.NurseName.MaxLength = 32767;
      this.NurseName.Name = "NurseName";
      this.NurseName.Size = new System.Drawing.Size(172, 35);
      this.NurseName.TabIndex = 12;
      this.NurseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // NurseId
      // 
      this.NurseId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
      this.NurseId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
      this.NurseId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.NurseId.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.NurseId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NurseId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NurseId.HintText = "Nurse ID";
      this.NurseId.isPassword = false;
      this.NurseId.LineFocusedColor = System.Drawing.Color.BlueViolet;
      this.NurseId.LineIdleColor = System.Drawing.Color.Gray;
      this.NurseId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
      this.NurseId.LineThickness = 3;
      this.NurseId.Location = new System.Drawing.Point(44, 171);
      this.NurseId.Margin = new System.Windows.Forms.Padding(5);
      this.NurseId.MaxLength = 32767;
      this.NurseId.Name = "NurseId";
      this.NurseId.Size = new System.Drawing.Size(172, 35);
      this.NurseId.TabIndex = 11;
      this.NurseId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // HomeButton
      // 
      this.HomeButton.BackColor = System.Drawing.Color.DarkGreen;
      this.HomeButton.FlatAppearance.BorderSize = 0;
      this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.HomeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.HomeButton.Location = new System.Drawing.Point(155, 550);
      this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.HomeButton.Name = "HomeButton";
      this.HomeButton.Size = new System.Drawing.Size(108, 51);
      this.HomeButton.TabIndex = 19;
      this.HomeButton.Text = "Home";
      this.HomeButton.UseVisualStyleBackColor = false;
      this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
      // 
      // DeleteButton
      // 
      this.DeleteButton.BackColor = System.Drawing.Color.DarkGreen;
      this.DeleteButton.FlatAppearance.BorderSize = 0;
      this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.DeleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.DeleteButton.Location = new System.Drawing.Point(271, 493);
      this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.DeleteButton.Name = "DeleteButton";
      this.DeleteButton.Size = new System.Drawing.Size(108, 51);
      this.DeleteButton.TabIndex = 18;
      this.DeleteButton.Text = "Delete";
      this.DeleteButton.UseVisualStyleBackColor = false;
      this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
      // 
      // UpdateButton
      // 
      this.UpdateButton.BackColor = System.Drawing.Color.DarkGreen;
      this.UpdateButton.FlatAppearance.BorderSize = 0;
      this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UpdateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.UpdateButton.Location = new System.Drawing.Point(155, 493);
      this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.UpdateButton.Name = "UpdateButton";
      this.UpdateButton.Size = new System.Drawing.Size(108, 51);
      this.UpdateButton.TabIndex = 17;
      this.UpdateButton.Text = "Update";
      this.UpdateButton.UseVisualStyleBackColor = false;
      this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // AddButton
      // 
      this.AddButton.BackColor = System.Drawing.Color.DarkGreen;
      this.AddButton.FlatAppearance.BorderSize = 0;
      this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.AddButton.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.AddButton.Location = new System.Drawing.Point(40, 493);
      this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(108, 51);
      this.AddButton.TabIndex = 16;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = false;
      this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // NurseGV
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      this.NurseGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.NurseGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.NurseGV.ColumnHeadersHeight = 25;
      this.NurseGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.NurseGV.DefaultCellStyle = dataGridViewCellStyle3;
      this.NurseGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      this.NurseGV.Location = new System.Drawing.Point(437, 171);
      this.NurseGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.NurseGV.Name = "NurseGV";
      this.NurseGV.RowHeadersVisible = false;
      this.NurseGV.RowTemplate.Height = 30;
      this.NurseGV.Size = new System.Drawing.Size(761, 495);
      this.NurseGV.TabIndex = 20;
      this.NurseGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
      this.NurseGV.ThemeStyle.AlternatingRowsStyle.Font = null;
      this.NurseGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
      this.NurseGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
      this.NurseGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
      this.NurseGV.ThemeStyle.BackColor = System.Drawing.Color.White;
      this.NurseGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      this.NurseGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
      this.NurseGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.NurseGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NurseGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
      this.NurseGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
      this.NurseGV.ThemeStyle.HeaderStyle.Height = 25;
      this.NurseGV.ThemeStyle.ReadOnly = false;
      this.NurseGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
      this.NurseGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.NurseGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NurseGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      this.NurseGV.ThemeStyle.RowsStyle.Height = 30;
      this.NurseGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
      this.NurseGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
      this.NurseGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NurseGV_CellContentClick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.Purple;
      this.label3.Location = new System.Drawing.Point(657, 120);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(204, 33);
      this.label3.TabIndex = 21;
      this.label3.Text = "NURSES LIST";
      // 
      // NurseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1260, 670);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.HomeButton);
      this.Controls.Add(this.DeleteButton);
      this.Controls.Add(this.UpdateButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.NurseSurname);
      this.Controls.Add(this.NursePass);
      this.Controls.Add(this.NurseExp);
      this.Controls.Add(this.NurseName);
      this.Controls.Add(this.NurseId);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.NurseGV);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "NurseForm";
      this.Text = "NurseForm";
      this.Load += new System.EventHandler(this.NurseForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NurseGV)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private Bunifu.Framework.UI.BunifuMaterialTextbox NurseSurname;
    private Bunifu.Framework.UI.BunifuMaterialTextbox NursePass;
    private Bunifu.Framework.UI.BunifuMaterialTextbox NurseExp;
    private Bunifu.Framework.UI.BunifuMaterialTextbox NurseName;
    private Bunifu.Framework.UI.BunifuMaterialTextbox NurseId;
    private System.Windows.Forms.Button HomeButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Button UpdateButton;
    private System.Windows.Forms.Button AddButton;
    private Guna.UI2.WinForms.Guna2DataGridView NurseGV;
    private System.Windows.Forms.Label label3;
    }
}