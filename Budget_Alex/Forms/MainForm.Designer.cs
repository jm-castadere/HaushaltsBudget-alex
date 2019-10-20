namespace Budget_Alex { 
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabCtrMain = new System.Windows.Forms.TabControl();
            this.tabErfassung = new System.Windows.Forms.TabPage();
            this.panHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labEingabeSumme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labEingabeName = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveEingeben = new System.Windows.Forms.Button();
            this.btnAddEingeben = new System.Windows.Forms.Button();
            this.btnEditEingeben = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labSumDiff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labSumAusgabe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labSumEingabe = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkFilterMonate = new System.Windows.Forms.CheckBox();
            this.grbFilterTyp = new System.Windows.Forms.GroupBox();
            this.rbtFilterAus = new System.Windows.Forms.RadioButton();
            this.rbtFilterEin = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboFilterMonat = new System.Windows.Forms.ComboBox();
            this.btnSearchClean = new System.Windows.Forms.Button();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.cboFilterJahr = new System.Windows.Forms.ComboBox();
            this.btnSearchEingeben = new System.Windows.Forms.Button();
            this.datGridEingaben = new System.Windows.Forms.DataGridView();
            this.bindingNavEingaben = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.labUser = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.tabCtrMain.SuspendLayout();
            this.tabErfassung.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grbFilterTyp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datGridEingaben)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavEingaben)).BeginInit();
            this.bindingNavEingaben.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrMain
            // 
            this.tabCtrMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrMain.Controls.Add(this.tabErfassung);
            this.tabCtrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrMain.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCtrMain.ItemSize = new System.Drawing.Size(150, 40);
            this.tabCtrMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrMain.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.tabCtrMain.Name = "tabCtrMain";
            this.tabCtrMain.Padding = new System.Drawing.Point(5, 5);
            this.tabCtrMain.SelectedIndex = 0;
            this.tabCtrMain.Size = new System.Drawing.Size(1484, 861);
            this.tabCtrMain.TabIndex = 3;
            // 
            // tabErfassung
            // 
            this.tabErfassung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabErfassung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabErfassung.Controls.Add(this.panHeader);
            this.tabErfassung.Controls.Add(this.datGridEingaben);
            this.tabErfassung.Controls.Add(this.bindingNavEingaben);
            this.tabErfassung.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabErfassung.ForeColor = System.Drawing.Color.Black;
            this.tabErfassung.Location = new System.Drawing.Point(4, 44);
            this.tabErfassung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabErfassung.Name = "tabErfassung";
            this.tabErfassung.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabErfassung.Size = new System.Drawing.Size(1476, 813);
            this.tabErfassung.TabIndex = 1;
            this.tabErfassung.Text = "Budgeterfassung";
            // 
            // panHeader
            // 
            this.panHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panHeader.Controls.Add(this.label3);
            this.panHeader.Controls.Add(this.labEingabeSumme);
            this.panHeader.Controls.Add(this.label5);
            this.panHeader.Controls.Add(this.labEingabeName);
            this.panHeader.Controls.Add(this.groupBox4);
            this.panHeader.Controls.Add(this.groupBox5);
            this.panHeader.Controls.Add(this.groupBox6);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(4, 30);
            this.panHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1466, 110);
            this.panHeader.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1062, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Betrag :";
            // 
            // labEingabeSumme
            // 
            this.labEingabeSumme.AutoSize = true;
            this.labEingabeSumme.BackColor = System.Drawing.Color.Gainsboro;
            this.labEingabeSumme.Location = new System.Drawing.Point(1124, 83);
            this.labEingabeSumme.Name = "labEingabeSumme";
            this.labEingabeSumme.Size = new System.Drawing.Size(55, 16);
            this.labEingabeSumme.TabIndex = 8;
            this.labEingabeSumme.Text = "Summe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Beschreibung :";
            // 
            // labEingabeName
            // 
            this.labEingabeName.AutoSize = true;
            this.labEingabeName.BackColor = System.Drawing.Color.Gainsboro;
            this.labEingabeName.Location = new System.Drawing.Point(857, 83);
            this.labEingabeName.Name = "labEingabeName";
            this.labEingabeName.Size = new System.Drawing.Size(44, 16);
            this.labEingabeName.TabIndex = 6;
            this.labEingabeName.Text = "Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveEingeben);
            this.groupBox4.Controls.Add(this.btnAddEingeben);
            this.groupBox4.Controls.Add(this.btnEditEingeben);
            this.groupBox4.Location = new System.Drawing.Point(1202, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 104);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnRemoveEingeben
            // 
            this.btnRemoveEingeben.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveEingeben.Image = global::Budget_Alex.Properties.Resources.minus;
            this.btnRemoveEingeben.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEingeben.Location = new System.Drawing.Point(20, 73);
            this.btnRemoveEingeben.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveEingeben.Name = "btnRemoveEingeben";
            this.btnRemoveEingeben.Size = new System.Drawing.Size(117, 25);
            this.btnRemoveEingeben.TabIndex = 10;
            this.btnRemoveEingeben.Text = "Löschen";
            this.btnRemoveEingeben.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveEingeben.UseVisualStyleBackColor = true;
            this.btnRemoveEingeben.Click += new System.EventHandler(this.btnRemoveEingeben_Click);
            // 
            // btnAddEingeben
            // 
            this.btnAddEingeben.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEingeben.Image = global::Budget_Alex.Properties.Resources.plus;
            this.btnAddEingeben.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEingeben.Location = new System.Drawing.Point(20, 13);
            this.btnAddEingeben.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddEingeben.Name = "btnAddEingeben";
            this.btnAddEingeben.Size = new System.Drawing.Size(117, 25);
            this.btnAddEingeben.TabIndex = 8;
            this.btnAddEingeben.Text = "Hinzufügen ";
            this.btnAddEingeben.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEingeben.UseVisualStyleBackColor = true;
            this.btnAddEingeben.Click += new System.EventHandler(this.btnAddEingeben_Click);
            // 
            // btnEditEingeben
            // 
            this.btnEditEingeben.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEingeben.Image = global::Budget_Alex.Properties.Resources.edit;
            this.btnEditEingeben.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEingeben.Location = new System.Drawing.Point(20, 42);
            this.btnEditEingeben.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditEingeben.Name = "btnEditEingeben";
            this.btnEditEingeben.Size = new System.Drawing.Size(117, 27);
            this.btnEditEingeben.TabIndex = 9;
            this.btnEditEingeben.Text = "Berarbeiten";
            this.btnEditEingeben.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditEingeben.UseVisualStyleBackColor = true;
            this.btnEditEingeben.Click += new System.EventHandler(this.btnEditEingeben_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labSumDiff);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.labSumAusgabe);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.labSumEingabe);
            this.groupBox5.Location = new System.Drawing.Point(754, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(434, 74);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summenberechnung";
            // 
            // labSumDiff
            // 
            this.labSumDiff.AutoSize = true;
            this.labSumDiff.BackColor = System.Drawing.Color.LemonChiffon;
            this.labSumDiff.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSumDiff.Location = new System.Drawing.Point(174, 50);
            this.labSumDiff.Name = "labSumDiff";
            this.labSumDiff.Size = new System.Drawing.Size(71, 16);
            this.labSumDiff.TabIndex = 15;
            this.labSumDiff.Text = "Diff-Sum";
            this.labSumDiff.TextChanged += new System.EventHandler(this.labSumDiff_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Differenz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ausgaben :";
            // 
            // labSumAusgabe
            // 
            this.labSumAusgabe.AutoSize = true;
            this.labSumAusgabe.BackColor = System.Drawing.Color.LightPink;
            this.labSumAusgabe.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSumAusgabe.Location = new System.Drawing.Point(322, 22);
            this.labSumAusgabe.Name = "labSumAusgabe";
            this.labSumAusgabe.Size = new System.Drawing.Size(74, 16);
            this.labSumAusgabe.TabIndex = 12;
            this.labSumAusgabe.Text = "Aus-Sum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Einkommen:";
            // 
            // labSumEingabe
            // 
            this.labSumEingabe.AutoSize = true;
            this.labSumEingabe.BackColor = System.Drawing.Color.PaleGreen;
            this.labSumEingabe.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSumEingabe.Location = new System.Drawing.Point(109, 22);
            this.labSumEingabe.Name = "labSumEingabe";
            this.labSumEingabe.Size = new System.Drawing.Size(69, 16);
            this.labSumEingabe.TabIndex = 10;
            this.labSumEingabe.Text = "Ein-Sum";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labUser);
            this.groupBox6.Controls.Add(this.cboUser);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.chkFilterMonate);
            this.groupBox6.Controls.Add(this.grbFilterTyp);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.cboFilterMonat);
            this.groupBox6.Controls.Add(this.btnSearchClean);
            this.groupBox6.Controls.Add(this.txtFilterName);
            this.groupBox6.Controls.Add(this.cboFilterJahr);
            this.groupBox6.Controls.Add(this.btnSearchEingeben);
            this.groupBox6.Location = new System.Drawing.Point(9, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(731, 104);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Beschreibung";
            // 
            // chkFilterMonate
            // 
            this.chkFilterMonate.AutoSize = true;
            this.chkFilterMonate.Location = new System.Drawing.Point(281, 72);
            this.chkFilterMonate.Name = "chkFilterMonate";
            this.chkFilterMonate.Size = new System.Drawing.Size(89, 20);
            this.chkFilterMonate.TabIndex = 10;
            this.chkFilterMonate.Text = "Fixkosten";
            this.chkFilterMonate.UseVisualStyleBackColor = true;
            // 
            // grbFilterTyp
            // 
            this.grbFilterTyp.Controls.Add(this.rbtFilterAus);
            this.grbFilterTyp.Controls.Add(this.rbtFilterEin);
            this.grbFilterTyp.Controls.Add(this.groupBox8);
            this.grbFilterTyp.Location = new System.Drawing.Point(282, 10);
            this.grbFilterTyp.Margin = new System.Windows.Forms.Padding(1);
            this.grbFilterTyp.Name = "grbFilterTyp";
            this.grbFilterTyp.Padding = new System.Windows.Forms.Padding(2);
            this.grbFilterTyp.Size = new System.Drawing.Size(294, 46);
            this.grbFilterTyp.TabIndex = 9;
            this.grbFilterTyp.TabStop = false;
            // 
            // rbtFilterAus
            // 
            this.rbtFilterAus.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtFilterAus.Image = global::Budget_Alex.Properties.Resources.minus;
            this.rbtFilterAus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtFilterAus.Location = new System.Drawing.Point(162, 15);
            this.rbtFilterAus.Name = "rbtFilterAus";
            this.rbtFilterAus.Size = new System.Drawing.Size(110, 25);
            this.rbtFilterAus.TabIndex = 4;
            this.rbtFilterAus.TabStop = true;
            this.rbtFilterAus.Text = "Ausgaben";
            this.rbtFilterAus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtFilterAus.UseVisualStyleBackColor = true;
            // 
            // rbtFilterEin
            // 
            this.rbtFilterEin.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtFilterEin.Image = global::Budget_Alex.Properties.Resources.plus;
            this.rbtFilterEin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtFilterEin.Location = new System.Drawing.Point(11, 15);
            this.rbtFilterEin.Name = "rbtFilterEin";
            this.rbtFilterEin.Size = new System.Drawing.Size(118, 25);
            this.rbtFilterEin.TabIndex = 3;
            this.rbtFilterEin.TabStop = true;
            this.rbtFilterEin.Text = "Einkommen";
            this.rbtFilterEin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtFilterEin.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(2, 51);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(146, 20);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Jahr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Monat";
            // 
            // cboFilterMonat
            // 
            this.cboFilterMonat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterMonat.FormattingEnabled = true;
            this.cboFilterMonat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboFilterMonat.Location = new System.Drawing.Point(209, 22);
            this.cboFilterMonat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFilterMonat.Name = "cboFilterMonat";
            this.cboFilterMonat.Size = new System.Drawing.Size(50, 24);
            this.cboFilterMonat.TabIndex = 1;
            // 
            // btnSearchClean
            // 
            this.btnSearchClean.Image = global::Budget_Alex.Properties.Resources.delete;
            this.btnSearchClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchClean.Location = new System.Drawing.Point(593, 62);
            this.btnSearchClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchClean.Name = "btnSearchClean";
            this.btnSearchClean.Size = new System.Drawing.Size(123, 25);
            this.btnSearchClean.TabIndex = 7;
            this.btnSearchClean.Text = "Zurücksetzen";
            this.btnSearchClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchClean.UseVisualStyleBackColor = true;
            this.btnSearchClean.Click += new System.EventHandler(this.btnSearchClean_Click);
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(10, 71);
            this.txtFilterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(253, 23);
            this.txtFilterName.TabIndex = 2;
            // 
            // cboFilterJahr
            // 
            this.cboFilterJahr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterJahr.FormattingEnabled = true;
            this.cboFilterJahr.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cboFilterJahr.Location = new System.Drawing.Point(54, 22);
            this.cboFilterJahr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFilterJahr.Name = "cboFilterJahr";
            this.cboFilterJahr.Size = new System.Drawing.Size(80, 24);
            this.cboFilterJahr.TabIndex = 0;
            // 
            // btnSearchEingeben
            // 
            this.btnSearchEingeben.Location = new System.Drawing.Point(593, 23);
            this.btnSearchEingeben.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchEingeben.Name = "btnSearchEingeben";
            this.btnSearchEingeben.Size = new System.Drawing.Size(123, 25);
            this.btnSearchEingeben.TabIndex = 6;
            this.btnSearchEingeben.Text = "Suchen";
            this.btnSearchEingeben.UseVisualStyleBackColor = true;
            this.btnSearchEingeben.Click += new System.EventHandler(this.btnSearchEingeben_Click);
            // 
            // datGridEingaben
            // 
            this.datGridEingaben.AllowUserToAddRows = false;
            this.datGridEingaben.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.datGridEingaben.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datGridEingaben.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datGridEingaben.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datGridEingaben.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.datGridEingaben.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datGridEingaben.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datGridEingaben.ColumnHeadersHeight = 30;
            this.datGridEingaben.Location = new System.Drawing.Point(4, 139);
            this.datGridEingaben.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datGridEingaben.MultiSelect = false;
            this.datGridEingaben.Name = "datGridEingaben";
            this.datGridEingaben.ReadOnly = true;
            this.datGridEingaben.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datGridEingaben.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datGridEingaben.RowHeadersWidth = 25;
            this.datGridEingaben.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datGridEingaben.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FloralWhite;
            this.datGridEingaben.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.datGridEingaben.RowTemplate.Height = 24;
            this.datGridEingaben.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datGridEingaben.Size = new System.Drawing.Size(1466, 667);
            this.datGridEingaben.TabIndex = 11;
            this.datGridEingaben.TabStop = false;
            this.datGridEingaben.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DatGridEingaben_CellFormatting);
            this.datGridEingaben.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatGridEingabenCellMouseDoubleClick);
            this.datGridEingaben.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datGridEingaben_CellMouseEnter);
            this.datGridEingaben.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DatGridEingaben_DataBindingComplete);
            this.datGridEingaben.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.datGridEingaben_RowPrePaint);
            this.datGridEingaben.Sorted += new System.EventHandler(this.DatGridEingabenSorted);
            this.datGridEingaben.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatGridEingabenKeyDown);
            // 
            // bindingNavEingaben
            // 
            this.bindingNavEingaben.AddNewItem = this.toolStripButton1;
            this.bindingNavEingaben.CountItem = this.toolStripLabel1;
            this.bindingNavEingaben.DeleteItem = this.toolStripButton2;
            this.bindingNavEingaben.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavEingaben.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavEingaben.Location = new System.Drawing.Point(4, 3);
            this.bindingNavEingaben.MoveFirstItem = this.toolStripButton3;
            this.bindingNavEingaben.MoveLastItem = this.toolStripButton6;
            this.bindingNavEingaben.MoveNextItem = this.toolStripButton5;
            this.bindingNavEingaben.MovePreviousItem = this.toolStripButton4;
            this.bindingNavEingaben.Name = "bindingNavEingaben";
            this.bindingNavEingaben.PositionItem = this.toolStripTextBox1;
            this.bindingNavEingaben.Size = new System.Drawing.Size(1466, 27);
            this.bindingNavEingaben.TabIndex = 12;
            this.bindingNavEingaben.Text = "bindingNavigator2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Hinzufügen";
            this.toolStripButton1.Click += new System.EventHandler(this.bindingNavEingabenAddNewItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Löschen";
            this.toolStripButton2.ToolTipText = "Löschen";
            this.toolStripButton2.Click += new System.EventHandler(this.bindingNavEingabenDeleteItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(49, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(381, 73);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(51, 16);
            this.labUser.TabIndex = 24;
            this.labUser.Text = "Nutzer";
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
            this.cboUser.Location = new System.Drawing.Point(435, 69);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(141, 24);
            this.cboUser.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.tabCtrMain);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haushaltsbudget";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabCtrMain.ResumeLayout(false);
            this.tabErfassung.ResumeLayout(false);
            this.tabErfassung.PerformLayout();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grbFilterTyp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datGridEingaben)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavEingaben)).EndInit();
            this.bindingNavEingaben.ResumeLayout(false);
            this.bindingNavEingaben.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtrMain;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoveEingeben;
        private System.Windows.Forms.Button btnAddEingeben;
        private System.Windows.Forms.Button btnEditEingeben;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSearchClean;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.ComboBox cboFilterJahr;
        private System.Windows.Forms.Button btnSearchEingeben;
        private System.Windows.Forms.DataGridView datGridEingaben;
        private System.Windows.Forms.BindingNavigator bindingNavEingaben;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox cboFilterMonat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbFilterTyp;
        private System.Windows.Forms.RadioButton rbtFilterAus;
        private System.Windows.Forms.RadioButton rbtFilterEin;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkFilterMonate;
        public System.Windows.Forms.TabPage tabErfassung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labEingabeSumme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labEingabeName;
        private System.Windows.Forms.Label labSumDiff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSumAusgabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSumEingabe;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.ComboBox cboUser;
    }
}

