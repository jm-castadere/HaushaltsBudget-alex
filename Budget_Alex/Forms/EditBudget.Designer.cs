namespace Budget_Alex
{
    partial class EditBudget
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.labBeschreibung = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labSum = new System.Windows.Forms.Label();
            this.txtSumme = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.rdbAus = new System.Windows.Forms.RadioButton();
            this.rdbEin = new System.Windows.Forms.RadioButton();
            this.grbMonatliche = new System.Windows.Forms.GroupBox();
            this.datPicEndFix = new System.Windows.Forms.DateTimePicker();
            this.labPicEndFix = new System.Windows.Forms.Label();
            this.rdbMonatNein = new System.Windows.Forms.RadioButton();
            this.rdbMonatJA = new System.Windows.Forms.RadioButton();
            this.labDate = new System.Windows.Forms.Label();
            this.datPicBudget = new System.Windows.Forms.DateTimePicker();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.labUser = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grbType.SuspendLayout();
            this.grbMonatliche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 54);
            this.panel1.TabIndex = 14;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(16, 11);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(175, 28);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(347, 11);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(175, 28);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Abbrechen";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // labBeschreibung
            // 
            this.labBeschreibung.AutoSize = true;
            this.labBeschreibung.Location = new System.Drawing.Point(13, 127);
            this.labBeschreibung.Name = "labBeschreibung";
            this.labBeschreibung.Size = new System.Drawing.Size(109, 16);
            this.labBeschreibung.TabIndex = 0;
            this.labBeschreibung.Text = "Beschreibung *";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 125);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.MaxLength = 140;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(394, 23);
            this.txtName.TabIndex = 5;
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.Location = new System.Drawing.Point(13, 172);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(69, 16);
            this.labSum.TabIndex = 2;
            this.labSum.Text = "Summe *";
            // 
            // txtSumme
            // 
            this.txtSumme.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSumme.Location = new System.Drawing.Point(124, 168);
            this.txtSumme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSumme.MaxLength = 10;
            this.txtSumme.Name = "txtSumme";
            this.txtSumme.Size = new System.Drawing.Size(111, 23);
            this.txtSumme.TabIndex = 6;
            this.txtSumme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSumme_KeyPress);
            this.txtSumme.Validated += new System.EventHandler(this.txtSumme_Validated);
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(124, 211);
            this.txtReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReference.MaxLength = 100;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(394, 23);
            this.txtReference.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Notiz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Euro";
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.rdbAus);
            this.grbType.Controls.Add(this.rdbEin);
            this.grbType.Location = new System.Drawing.Point(124, 8);
            this.grbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbType.Name = "grbType";
            this.grbType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbType.Size = new System.Drawing.Size(296, 54);
            this.grbType.TabIndex = 1;
            this.grbType.TabStop = false;
            this.grbType.Text = "Type";
            // 
            // rdbAus
            // 
            this.rdbAus.ForeColor = System.Drawing.Color.DarkRed;
            this.rdbAus.Image = global::Budget_Alex.Properties.Resources.minus;
            this.rdbAus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbAus.Location = new System.Drawing.Point(154, 18);
            this.rdbAus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbAus.Name = "rdbAus";
            this.rdbAus.Size = new System.Drawing.Size(126, 27);
            this.rdbAus.TabIndex = 3;
            this.rdbAus.TabStop = true;
            this.rdbAus.Text = "Ausgaben";
            this.rdbAus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbAus.UseVisualStyleBackColor = true;
            this.rdbAus.CheckedChanged += new System.EventHandler(this.rdbAus_CheckedChanged);
            // 
            // rdbEin
            // 
            this.rdbEin.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdbEin.Image = global::Budget_Alex.Properties.Resources.plus;
            this.rdbEin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbEin.Location = new System.Drawing.Point(19, 18);
            this.rdbEin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbEin.Name = "rdbEin";
            this.rdbEin.Size = new System.Drawing.Size(123, 27);
            this.rdbEin.TabIndex = 2;
            this.rdbEin.TabStop = true;
            this.rdbEin.Text = "Einkommen";
            this.rdbEin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdbEin.UseVisualStyleBackColor = true;
            this.rdbEin.CheckedChanged += new System.EventHandler(this.rdbEin_CheckedChanged);
            // 
            // grbMonatliche
            // 
            this.grbMonatliche.Controls.Add(this.datPicEndFix);
            this.grbMonatliche.Controls.Add(this.labPicEndFix);
            this.grbMonatliche.Controls.Add(this.rdbMonatNein);
            this.grbMonatliche.Controls.Add(this.rdbMonatJA);
            this.grbMonatliche.Location = new System.Drawing.Point(124, 254);
            this.grbMonatliche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMonatliche.Name = "grbMonatliche";
            this.grbMonatliche.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMonatliche.Size = new System.Drawing.Size(402, 54);
            this.grbMonatliche.TabIndex = 19;
            this.grbMonatliche.TabStop = false;
            this.grbMonatliche.Text = "Fixkosten";
            // 
            // datPicEndFix
            // 
            this.datPicEndFix.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPicEndFix.Location = new System.Drawing.Point(245, 21);
            this.datPicEndFix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datPicEndFix.Name = "datPicEndFix";
            this.datPicEndFix.Size = new System.Drawing.Size(142, 23);
            this.datPicEndFix.TabIndex = 23;
            this.datPicEndFix.VisibleChanged += new System.EventHandler(this.datPicEndFix_VisibleChanged);
            // 
            // labPicEndFix
            // 
            this.labPicEndFix.AutoSize = true;
            this.labPicEndFix.Location = new System.Drawing.Point(160, 23);
            this.labPicEndFix.Name = "labPicEndFix";
            this.labPicEndFix.Size = new System.Drawing.Size(73, 16);
            this.labPicEndFix.TabIndex = 24;
            this.labPicEndFix.Text = "Enddatum";
            // 
            // rdbMonatNein
            // 
            this.rdbMonatNein.AutoSize = true;
            this.rdbMonatNein.Location = new System.Drawing.Point(79, 21);
            this.rdbMonatNein.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMonatNein.Name = "rdbMonatNein";
            this.rdbMonatNein.Size = new System.Drawing.Size(54, 20);
            this.rdbMonatNein.TabIndex = 9;
            this.rdbMonatNein.TabStop = true;
            this.rdbMonatNein.Text = "Nein";
            this.rdbMonatNein.UseVisualStyleBackColor = true;
            this.rdbMonatNein.CheckedChanged += new System.EventHandler(this.rdbMonatNein_CheckedChanged);
            // 
            // rdbMonatJA
            // 
            this.rdbMonatJA.AutoSize = true;
            this.rdbMonatJA.Location = new System.Drawing.Point(19, 21);
            this.rdbMonatJA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMonatJA.Name = "rdbMonatJA";
            this.rdbMonatJA.Size = new System.Drawing.Size(40, 20);
            this.rdbMonatJA.TabIndex = 8;
            this.rdbMonatJA.TabStop = true;
            this.rdbMonatJA.Text = "Ja";
            this.rdbMonatJA.UseVisualStyleBackColor = true;
            this.rdbMonatJA.CheckedChanged += new System.EventHandler(this.rdbMonatJA_CheckedChanged);
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(13, 85);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(64, 16);
            this.labDate.TabIndex = 20;
            this.labDate.Text = "Datum *";
            // 
            // datPicBudget
            // 
            this.datPicBudget.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPicBudget.Location = new System.Drawing.Point(124, 82);
            this.datPicBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datPicBudget.Name = "datPicBudget";
            this.datPicBudget.Size = new System.Drawing.Size(142, 23);
            this.datPicBudget.TabIndex = 4;
            // 
            // cboUser
            // 
            this.cboUser.AutoCompleteCustomSource.AddRange(new string[] {
            "Alexandre",
            "Robert",
            "Sonstig"});
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Alexandre",
            "Robert",
            "Sonstig"});
            this.cboUser.Location = new System.Drawing.Point(347, 82);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(171, 24);
            this.cboUser.TabIndex = 21;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(280, 85);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(51, 16);
            this.labUser.TabIndex = 22;
            this.labUser.Text = "Nutzer";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.txtSumme_Validated);
            // 
            // EditBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 377);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.datPicBudget);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.grbMonatliche);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSumme);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labBeschreibung);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Changes";
            this.panel1.ResumeLayout(false);
            this.grbType.ResumeLayout(false);
            this.grbMonatliche.ResumeLayout(false);
            this.grbMonatliche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label labBeschreibung;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.TextBox txtSumme;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.RadioButton rdbAus;
        private System.Windows.Forms.RadioButton rdbEin;
        private System.Windows.Forms.GroupBox grbMonatliche;
        private System.Windows.Forms.RadioButton rdbMonatNein;
        private System.Windows.Forms.RadioButton rdbMonatJA;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.DateTimePicker datPicBudget;
        private System.Windows.Forms.DateTimePicker datPicEndFix;
        private System.Windows.Forms.Label labPicEndFix;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}