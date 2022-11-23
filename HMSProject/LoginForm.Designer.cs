namespace HMSProject
{
  partial class LoginForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.DocNameTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
      this.PassTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.Role = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGreen;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1381, 109);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label1.Location = new System.Drawing.Point(268, 31);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(860, 42);
      this.label1.TabIndex = 0;
      this.label1.Text = "Hospital Management System- Bethlehem Hospital";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.DarkGreen;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.button1.Location = new System.Drawing.Point(576, 440);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(261, 71);
      this.button1.TabIndex = 1;
      this.button1.Text = "Login";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // DocNameTb
      // 
      this.DocNameTb.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
      this.DocNameTb.BorderColorIdle = System.Drawing.Color.LimeGreen;
      this.DocNameTb.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
      this.DocNameTb.BorderThickness = 3;
      this.DocNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.DocNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.DocNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.DocNameTb.ForeColor = System.Drawing.Color.DarkGreen;
      this.DocNameTb.isPassword = false;
      this.DocNameTb.Location = new System.Drawing.Point(576, 200);
      this.DocNameTb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.DocNameTb.MaxLength = 32767;
      this.DocNameTb.Name = "DocNameTb";
      this.DocNameTb.Size = new System.Drawing.Size(261, 65);
      this.DocNameTb.TabIndex = 2;
      this.DocNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // PassTb
      // 
      this.PassTb.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
      this.PassTb.BorderColorIdle = System.Drawing.Color.LimeGreen;
      this.PassTb.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
      this.PassTb.BorderThickness = 3;
      this.PassTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.PassTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PassTb.ForeColor = System.Drawing.Color.DarkGreen;
      this.PassTb.isPassword = true;
      this.PassTb.Location = new System.Drawing.Point(576, 315);
      this.PassTb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.PassTb.MaxLength = 32767;
      this.PassTb.Name = "PassTb";
      this.PassTb.Size = new System.Drawing.Size(261, 65);
      this.PassTb.TabIndex = 3;
      this.PassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.DarkGreen;
      this.label2.Location = new System.Drawing.Point(671, 557);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 29);
      this.label2.TabIndex = 4;
      this.label2.Text = "Clear";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label4.ForeColor = System.Drawing.Color.DarkGreen;
      this.label4.Location = new System.Drawing.Point(60, 594);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(219, 29);
      this.label4.TabIndex = 6;
      this.label4.Text = "Connection Status: ";
      // 
      // Role
      // 
      this.Role.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.Role.FormattingEnabled = true;
      this.Role.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Nurse"});
      this.Role.Location = new System.Drawing.Point(1104, 592);
      this.Role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Role.Name = "Role";
      this.Role.Size = new System.Drawing.Size(195, 29);
      this.Role.TabIndex = 9;
      this.Role.Text = "Who are you?";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.DarkGreen;
      this.label3.Location = new System.Drawing.Point(427, 212);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(136, 29);
      this.label3.TabIndex = 10;
      this.label3.Text = "Username: ";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.DarkGreen;
      this.label5.Location = new System.Drawing.Point(435, 329);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(132, 29);
      this.label5.TabIndex = 11;
      this.label5.Text = "Password: ";
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gainsboro;
      this.ClientSize = new System.Drawing.Size(1381, 663);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.Role);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.PassTb);
      this.Controls.Add(this.DocNameTb);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.LoginForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private Bunifu.Framework.UI.BunifuMetroTextbox DocNameTb;
    private Bunifu.Framework.UI.BunifuMetroTextbox PassTb;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox Role;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
  }
}