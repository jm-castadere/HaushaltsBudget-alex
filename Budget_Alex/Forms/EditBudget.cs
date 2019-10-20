using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Budget_Alex.Classes;
using Budget_Alex.DataEntity;

namespace Budget_Alex
{
    public partial class EditBudget : Form
    {
        public Budget DatBudget { get; set; }
        public bool Adding { get; set; }

        readonly string _errorMsg = "Ein Wert muss eingegeben werden";


        /// <summary>
        /// Constructor
        /// </summary>
        public EditBudget()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="EditBudget"/> class. 
        /// Init control
        /// </summary>
        /// <param name="parBudget">
        /// </param>
        /// <param name="isEingabe">
        /// </param>
        public EditBudget(Budget parBudget, bool isEingabe = true)
        {
            InitializeComponent();

            DatBudget = parBudget;

            //New budget----------
            if (string.IsNullOrWhiteSpace(parBudget.Name))
            {
                Adding = true;
                Text = "Budget-Linie hinzufügen";
                cmdSave.Text = "Hinzufügen";

                //Set einkommen
                rdbEin.Checked = isEingabe;
                txtSumme.BackColor = Color.LightGreen;

                //Not fixe
                rdbMonatNein.Checked = true;
                //Hide Fix Enddate
                datPicEndFix.Visible = false;
                labPicEndFix.Visible = false;

                //Date
                datPicBudget.Value = DateTime.Now;

                // user default
                cboUser.SelectedValue = "Sonstig";
                cboUser.SelectedIndex = 2;
            }
            else
            {
                //Change budget--------

                Adding = false;
                Text = "Budget-Linie bearbeiten";
                cmdSave.Text = "Speichern";

                txtName.Text = DatBudget.Name;
                txtReference.Text = DatBudget.Nr;

                txtSumme.Text = DatBudget.Summe.ToString();

                //Set date
                datPicBudget.Value = DatBudget.DateCreate;

                if (!string.IsNullOrEmpty(DatBudget.UserBudget))
                {
                    cboUser.SelectedItem = DatBudget.UserBudget;
                }

                //Budgte einkonnen or ausgaben
                if ((bool)DatBudget.IsEin)
                {
                    rdbEin.Checked = true;
                    txtSumme.BackColor = Color.LightGreen;
                }
                else
                {
                    rdbAus.Checked = true;
                    txtSumme.BackColor = Color.LightPink;
                }


                //Fixkosten--------
                if ((bool)DatBudget.IsFixe)
                {
                    //Yes
                    rdbMonatJA.Checked = true;

                    //Set fix endatum
                    datPicEndFix.Visible = false;
                    labPicEndFix.Visible = false;
                }
                //Not fixkosten---
                else
                {
                    rdbMonatNein.Checked = true;

                    //Hide fixendatum
                    datPicEndFix.Visible = false;
                    labPicEndFix.Visible = false;
                }
            }
        }


        /// <summary>
        /// Validation is done in the main form.
        /// </summary>
        /// <remarks>
        /// * No reason not to place validation here, I left that for you :-)
        /// * I avoided checking if the text properties of the TextBoxes 
        ///   are empty as we are focused on EF validation not form control 
        ///   validation
        /// </remarks>
        private void cmdSave_Click(object sender, EventArgs e)
        {
            Budgets clsBudget = new Budgets();

            if (txtSumme.Text.Length == 0)
            {
                // Set the ErrorProvider error with the text to display. 
                errorProvider1.SetError(txtSumme, _errorMsg);
                return;
            }
            if (txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, _errorMsg);
                return;
            }

            DatBudget.Name = txtName.Text;
            DatBudget.Name = txtName.Text;
            DatBudget.Summe = Convert.ToDouble(txtSumme.Text);
            DatBudget.Nr = txtReference.Text;
            DatBudget.IsEin = rdbEin.Checked;
            DatBudget.IsFixe = rdbMonatJA.Checked;

            if (cboUser.SelectedItem != null)
            {
                DatBudget.UserBudget = (string)this.cboUser.SelectedItem;
            }

            if (Adding)
            {
                //Insert New budget--------------
                //Set date created
                var datSelect = datPicBudget.Value;
                DatBudget.DateCreate = datSelect;
                DatBudget.Jahr = (short?)datSelect.Year;
                DatBudget.Monate = (short?)datSelect.Month;


                if (rdbMonatJA.Checked)
                {
                    //Fixkosten---------------

                    //Get date end fix
                    var datEndFix = datPicEndFix.Value;
                    //Get nunber monate
                    int nbrMonth = GetMonthsBetweenDates(datSelect, datEndFix);
                    //Set message
                    int msgNbMonate = nbrMonth;
                    var msg = string.Format("Möchten Sie das Budget-Linie (Anzahl Monaten :{0}) bis zum Datum {1} hinzufügen ?", 
                                                (msgNbMonate+1).ToString(), 
                                                datEndFix.ToShortDateString());
                    //Show message    
                    if (MessageBox.Show(msg, txtName.Text, MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    //Date Valid
                    DatBudget.DateEnd = datSelect.AddMonths(nbrMonth);

                    int posMonth = 0;

                    //Fro all monate
                    for (int i = 0; i < (nbrMonth + 1); i++)
                    {
                        //Error
                        if (!clsBudget.AddBudget(DatBudget))
                        {
                            MessageBox.Show(clsBudget.ValidationMessage);
                            break;
                        }

                        //add 1+ month
                        posMonth++;

                        //Set date create
                        DatBudget.DateCreate = datSelect.AddMonths(posMonth);
                        DatBudget.Jahr = (short?)datSelect.AddMonths(posMonth).Year;
                        DatBudget.Monate = (short?)datSelect.AddMonths(posMonth).Month;
                    }

                    GlobalApp.IsChanged = true;
                    DatBudget.Id = clsBudget.NewIdentifier;

                    CallMainForm();
                }
                else
                {
                    //Not fixkosten------------
                    //Error
                    if (!clsBudget.AddBudget(DatBudget))
                    {
                        MessageBox.Show(clsBudget.ValidationMessage);
                    }
                    else
                    {
                        //Set new id
                        DatBudget.Id = clsBudget.NewIdentifier;
                        CallMainForm();
                    }
                }
            }
            else
            {
                //update budget----------------

                //Set date changed
                var datSelect = datPicBudget.Value;

                DatBudget.DateCreate = datSelect;
                DatBudget.Jahr = (short?)datSelect.Year;
                DatBudget.Monate = (short?)datSelect.Month;

                if (!clsBudget.UpdateBudget(DatBudget))
                {
                    MessageBox.Show(clsBudget.ValidationMessage);
                }
                else
                {
                    CallMainForm();
                }
            }
        }


        private void CallMainForm()
        {
            DialogResult = DialogResult.OK;
            var frmMain = new MainForm();
            frmMain.LoadResultatCalculedForLabels();
            
            Close();
        }



        public static int GetMonthsBetweenDates(DateTime dateNow, DateTime dateEnd)
        {
            // Beide Daten in einer Liste speichern und sortieren 
            List<DateTime> period = new List<DateTime>() { dateNow, dateEnd.AddDays(1) };
            period.Sort(DateTime.Compare);

            // Monate zählen
            int months;
            for (months = 0; period[0].AddMonths(months + 1).CompareTo(period[1]) <= 0; months++) ;

            return months;
        }

        #region Control events


        /// <summary>
        /// Check only number enter
        /// </summary>
        private void txtSumme_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSumme_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSumme, "");
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, "");
        }

        private void rdbMonatJA_CheckedChanged(object sender, EventArgs e)
        {
            datPicEndFix.Visible = rdbMonatJA.Checked;
        }

        private void rdbMonatNein_CheckedChanged(object sender, EventArgs e)
        {
            datPicEndFix.Visible = !rdbMonatNein.Checked;
        }
        private void datPicEndFix_VisibleChanged(object sender, EventArgs e)
        {
            labPicEndFix.Visible = datPicEndFix.Visible;
            datPicEndFix.Enabled = Adding;
        }

        private void rdbEin_CheckedChanged(object sender, EventArgs e)
        {
            txtSumme.BackColor = Color.LightGreen;
        }

        private void rdbAus_CheckedChanged(object sender, EventArgs e)
        {
            txtSumme.BackColor = Color.LightPink;
        }

        #endregion

    }
}
