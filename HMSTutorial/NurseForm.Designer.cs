namespace HMSTutorial
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
            this.DocSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocExp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NurseName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NurseId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DoctorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 92);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(487, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "NURSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(307, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DocSurname
            // 
            this.DocSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocSurname.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocSurname.HintText = "Doctor Surname";
            this.DocSurname.isPassword = false;
            this.DocSurname.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocSurname.LineIdleColor = System.Drawing.Color.Gray;
            this.DocSurname.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocSurname.LineThickness = 3;
            this.DocSurname.Location = new System.Drawing.Point(38, 250);
            this.DocSurname.Margin = new System.Windows.Forms.Padding(4);
            this.DocSurname.Name = "DocSurname";
            this.DocSurname.Size = new System.Drawing.Size(147, 30);
            this.DocSurname.TabIndex = 15;
            this.DocSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DocPass
            // 
            this.DocPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocPass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocPass.HintText = "Password";
            this.DocPass.isPassword = false;
            this.DocPass.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocPass.LineIdleColor = System.Drawing.Color.Gray;
            this.DocPass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocPass.LineThickness = 3;
            this.DocPass.Location = new System.Drawing.Point(38, 351);
            this.DocPass.Margin = new System.Windows.Forms.Padding(4);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(147, 30);
            this.DocPass.TabIndex = 14;
            this.DocPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DocExp
            // 
            this.DocExp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocExp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocExp.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocExp.HintText = "Years Of Experience";
            this.DocExp.isPassword = false;
            this.DocExp.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocExp.LineIdleColor = System.Drawing.Color.Gray;
            this.DocExp.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocExp.LineThickness = 3;
            this.DocExp.Location = new System.Drawing.Point(38, 302);
            this.DocExp.Margin = new System.Windows.Forms.Padding(4);
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(147, 30);
            this.DocExp.TabIndex = 13;
            this.DocExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NurseName
            // 
            this.NurseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NurseName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NurseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NurseName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NurseName.HintText = "Name of Nurse";
            this.NurseName.isPassword = false;
            this.NurseName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.NurseName.LineIdleColor = System.Drawing.Color.Gray;
            this.NurseName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.NurseName.LineThickness = 3;
            this.NurseName.Location = new System.Drawing.Point(38, 198);
            this.NurseName.Margin = new System.Windows.Forms.Padding(4);
            this.NurseName.Name = "NurseName";
            this.NurseName.Size = new System.Drawing.Size(147, 30);
            this.NurseName.TabIndex = 12;
            this.NurseName.Text = "Doctor Name";
            this.NurseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NurseId
            // 
            this.NurseId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NurseId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NurseId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NurseId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NurseId.HintText = "Nurse ID";
            this.NurseId.isPassword = false;
            this.NurseId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.NurseId.LineIdleColor = System.Drawing.Color.Gray;
            this.NurseId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.NurseId.LineThickness = 3;
            this.NurseId.Location = new System.Drawing.Point(38, 148);
            this.NurseId.Margin = new System.Windows.Forms.Padding(4);
            this.NurseId.Name = "NurseId";
            this.NurseId.Size = new System.Drawing.Size(147, 30);
            this.NurseId.TabIndex = 11;
            this.NurseId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(133, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 44);
            this.button4.TabIndex = 19;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(232, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 44);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(133, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(34, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DoctorGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DoctorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorGV.BackgroundColor = System.Drawing.Color.White;
            this.DoctorGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DoctorGV.EnableHeadersVisualStyles = false;
            this.DoctorGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.Location = new System.Drawing.Point(347, 140);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.RowHeadersVisible = false;
            this.DoctorGV.RowTemplate.Height = 30;
            this.DoctorGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorGV.Size = new System.Drawing.Size(652, 429);
            this.DoctorGV.TabIndex = 20;
            this.DoctorGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.DoctorGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DoctorGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DoctorGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DoctorGV.ThemeStyle.ReadOnly = false;
            this.DoctorGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorGV.ThemeStyle.RowsStyle.Height = 30;
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(563, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "NURSES LIST";
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DocSurname);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.NurseName);
            this.Controls.Add(this.NurseId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NurseForm";
            this.Text = "NurseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocExp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NurseName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NurseId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorGV;
        private System.Windows.Forms.Label label3;
    }
}