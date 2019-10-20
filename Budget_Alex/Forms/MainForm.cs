using System.Drawing;
using static DialogLibrary.KarenDialogs;

namespace Budget_Alex
{
    using Classes;

    using CustomBindingList_cs;

    using DataEntity;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        // Budget
        private readonly BindingSource _binSourcBudget = new BindingSource();

        private SortableBindingList<Budget> _blistBudget = new SortableBindingList<Budget>();

        private Budget _currentBudget;

        private readonly BindingSource _binSourcResult = new BindingSource();

        private SortableBindingList<BudgetResult> _blistResult = new SortableBindingList<BudgetResult>();

        //class and code budget
        private Budgets _clsBudget;


        /// <summary>
        ///     Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

        }

        /// <summary>
        ///     Form loaded
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set budget
            SetBudget();
        }


        private void MainForm_Activated(object sender, System.EventArgs e)
        {
            if (GlobalApp.IsChanged)
            {
                //SetBudget();
                SearchBudget();
                //Sort
                SortGridDateCreate(true);
            }
        }

        #region Init budget 

        /// <summary>
        ///   Set budget data and control
        /// </summary>
        private void SetBudget()
        {
            _clsBudget = new Budgets();

            if (_clsBudget.DataSource == null)
            {
                MessageBox.Show("Kein Budget gefunden!");
                return;
            }

            // set list budget
            _blistBudget = new SortableBindingList<Budget>(this._clsBudget.DataSource);
            // Bind to the BindingList
            _binSourcBudget.DataSource = _blistBudget;
            // Set DataGridView DataSource
            datGridEingaben.DataSource = _binSourcBudget;

            //set result
            _blistResult = new SortableBindingList<BudgetResult>(this._clsBudget.GetBudgetResult.ToList());
            _binSourcResult.DataSource = _blistResult;

            //Set info label
            SetupBudgetDataBindingsForLabels();

            //Set grid style
            PrepareBudgetDataGridViewColumns();
            //Init events grid
            SetupBudgetEventsForDataGridViewSorting();

            //bind grid with datasoure
            _binSourcBudget.Position = 1;
            bindingNavEingaben.BindingSource = _binSourcBudget;

            //Set menu control
            bindingNavEingaben.DeleteItem = null;
            bindingNavEingaben.AddNewItem = null;

            //Fil jahr list
            SetJahrList();

        }

        /// <summary> fill list Jahr </summary>
        /// <example>
        ///  cboJahr.SelectedItem = DateTime.Now.Year.ToString();
        //   var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
        /// </example>
        private void SetJahrList()
        {
            cboFilterJahr.Items.Add("2018");
            cboFilterJahr.Items.Add("2019");
            cboFilterJahr.Items.Add("2020");
            cboFilterJahr.Items.Add("2021");
            cboFilterJahr.Items.Add("2022");
            cboFilterJahr.Items.Add("2023");
        }

        /// <summary>
        /// Setups the budget events for data grid view sorting.
        /// </summary>
        private void SetupBudgetEventsForDataGridViewSorting()
        {
            _binSourcBudget.PositionChanged += bindSoureBudget_PositionChanged;
            datGridEingaben.Sorted += this.DatGridEingabenSorted;
        }

        #endregion

        #region Button events

        /// <summary>
        /// Handles the Click event of the btnSearchEingeben control.
        /// </summary>
        private void btnSearchEingeben_Click(object sender, EventArgs e)
        {
            SearchBudget();
        }

        /// <summary>
        /// Handles the Click event of the btnAddEingeben control.
        /// </summary>
        private void btnAddEingeben_Click(object sender, EventArgs e)
        {
            AddNewBudget();
        }

        /// <summary>
        /// Handles the Click event of the btnEditEingeben control.
        /// </summary>
        private void btnEditEingeben_Click(object sender, EventArgs e)
        {
            EditCurrentBudgetRow();
        }

        /// <summary>
        /// Handles the Click event of the btnRemoveEingeben control.
        /// </summary>
        private void btnRemoveEingeben_Click(object sender, EventArgs e)
        {
            RemoveBudgetRow();
        }


        private void btnSumRefresh_Click(object sender, EventArgs e)
        {
            LoadResultatCalculedForLabels();
        }

        #endregion

        #region Menu button

        private void bindSoureBudget_PositionChanged(object sender, EventArgs e)
        {
            PositionChangedBudget();
        }

        private void bindingNavEingabenAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewBudget();
        }

        private void bindingNavEingabenDeleteItem_Click(object sender, EventArgs e)
        {
            RemoveBudgetRow();
        }

        #endregion

        #region Budget datagrid

        private void DatGridEingabenCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                EditCurrentBudgetRow();
            }
        }

        private void DatGridEingabenKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                RemoveBudgetRow();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                EditCurrentBudgetRow();
            }
        }

        private void DatGridEingabenSorted(object sender, EventArgs e)
        {
            if (_binSourcBudget.CurrentRowIsValid())
            {
                _binSourcBudget.Position = _binSourcBudget.IndexOf(_currentBudget);
            }
        }

        private void datGridEingaben_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            InitCellSumme(e);
        }

        private void DatGridEingaben_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Set summ calculed
            LoadResultatCalculedForLabels();
        }


        private void DatGridEingaben_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = (DataGridView)sender;

            if (e.ColumnIndex == datGridEingaben.Columns["Name"].Index)
            {
                bool valCell = true;
                if (datGridEingaben.Rows[e.RowIndex].Cells[datGridEingaben.Columns["IsEin"].Index].Value != null)
                {
                    valCell = (bool)datGridEingaben.Rows[e.RowIndex].Cells[datGridEingaben.Columns["IsEin"].Index].Value;
                }

                bool valEinFixe = false;
                if (datGridEingaben.Rows[e.RowIndex].Cells[datGridEingaben.Columns["IsFixe"].Index].Value != null)
                {
                        valEinFixe = (bool)datGridEingaben.Rows[e.RowIndex].Cells[datGridEingaben.Columns["IsFixe"].Index].Value;
                }


                if (dataGridView.Rows[e.RowIndex].Selected)
                {
                    if (valCell)
                    {
                        datGridEingaben.Rows[e.RowIndex].Cells[3].Style.Font = new Font(
                            e.CellStyle.Font,
                            FontStyle.Regular);
                        datGridEingaben.Rows[e.RowIndex].Cells[3].Style.SelectionBackColor = Color.LightGreen;
                    }
                    else
                    {
                        if (valEinFixe)
                        {
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.SelectionBackColor = Color.LightPink;
                        }
                        else
                        {
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.Font = new Font(e.CellStyle.Font, FontStyle.Regular);
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.SelectionBackColor = ColorTranslator.FromHtml("#ffdae0 ");
                        }
                    }
                }
                else
                {
                    if (valCell)
                    {
                        datGridEingaben.Rows[e.RowIndex].Cells[3].Style.Font = new Font(e.CellStyle.Font,FontStyle.Regular);
                        datGridEingaben.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        if (valEinFixe)
                        {
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.Font =new Font(e.CellStyle.Font, FontStyle.Bold);
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.LightPink;
                        }
                        else
                        {
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.Font = new Font(e.CellStyle.Font, FontStyle.Regular);
                            datGridEingaben.Rows[e.RowIndex].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#ffdae0 ");
                        }
                    }
                }
            }

            if (e.ColumnIndex == datGridEingaben.Columns["Summe"].Index|| 
                e.ColumnIndex == datGridEingaben.Columns["Name"].Index)
            {
                //Ste tooltip
                var cell = datGridEingaben.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Doppelklick zur Bearbeitung der Werte";
            }


            //else if (e.ColumnIndex == datGridEingaben.Columns["IsEin"].Index)
            //{
            //    //Ste tooltip
            //    bool valCell = (bool)datGridEingaben.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //    var ctrCell = datGridEingaben.Rows[e.RowIndex];//.Cells[e.ColumnIndex];
            //    if (valCell)
            //    {
            //        //if (e.Row.RowType == DataControlRowType.DataRow)
            //        //{
            //        //    if (e.Row.Cells[rowIndex].Text == "Total")
            //        //    {
            //        //        e.Row.Font.Bold = true;
            //        //    }
            //        //}
            //    }
            //    else
            //    {
            //        ctrCell.Value = "Ausgaben";
            //    }
            //}
        }

        #endregion


        /// <summary>
        /// Initializes the cell summe.
        /// </summary>
        /// <param name="e">The <see cref="DataGridViewRowPrePaintEventArgs"/> instance containing the event data.</param>
        private void InitCellSumme(DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToBoolean(datGridEingaben.Rows[e.RowIndex].Cells[1].Value))
            {
                datGridEingaben.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.LightGreen;
            }
            else
            {
                datGridEingaben.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Edits the current budget row.
        /// </summary>
        private void EditCurrentBudgetRow()
        {
            var datBudget = _blistBudget.FirstOrDefault(cust => cust.Id == _binSourcBudget.BudgetId());
            var f = new EditBudget(datBudget, true);
            try
            {
                if (f.ShowDialog() == DialogResult.OK) _binSourcBudget.ResetCurrentItem();
            }
            finally
            {
                f.Dispose();
            }
        }

        /// <summary>
        /// Positions the changed budget.
        /// </summary>
        private void PositionChangedBudget()
        {
            if (_binSourcBudget.CurrentRowIsValid())
            {
                _currentBudget = (DataEntity.Budget)_binSourcBudget.Current;
            }
            else
            {
                _currentBudget = null;
            }
        }

        /// <summary>
        ///     Add new budget
        /// </summary>
        private void AddNewBudget()
        {
            var datBudget = new DataEntity.Budget();

            // Show edit budget form
            var formEdit = new EditBudget(datBudget, true);
            try
            {
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    if (!GlobalApp.IsChanged)
                    {
                        SearchBudget();

                        //_blistBudget.Add(datBudget);
                        //_blistBudget.ResetBindings();
                    }

                    //reset flag multi enter
                    GlobalApp.IsChanged = false;

                    //sort
                    SortGridDateCreate(true);
                }
            }
            finally
            {
                formEdit.Dispose();
            }
        }

        /// <summary>
        /// Sorts the grid date create.
        /// </summary>
        /// <param name="isDesc">if set to <c>true</c> [is desc].</param>
        private void SortGridDateCreate(bool isDesc)
        {
            this.datGridEingaben.Sort(
                datGridEingaben.Columns["DateCreate"],
                isDesc ? ListSortDirection.Descending : ListSortDirection.Ascending);
        }

        /// <summary>
        ///     Remove current row
        /// </summary>
        private void RemoveBudgetRow()
        {
            if (Question($"Remove '{_binSourcBudget.BudgetName()}' ?"))
            {
                var clsBudget = new Budgets();

                clsBudget.RemoveBudget(_binSourcBudget.BudgetCurrent());

                _binSourcBudget.RemoveCurrent();

                ActiveControl = datGridEingaben;
            }
        }


        /// <summary>
        ///     Orders DataGridViewColumn does not attempt to set the width.
        /// </summary>
        private void PrepareBudgetDataGridViewColumns()
        {
            //Hide column
            HideColumn();

            InitColumn();
            foreach (DataGridViewColumn col in datGridEingaben.Columns)
            {
                if (col.Visible)
                {
                    //if (col.HeaderText == "DateCreate" || col.HeaderText == "DateChange")
                    //{
                    //    col.HeaderText = Regex.Replace(col.HeaderText, "(\\B[A-Z])", " $1");
                    //    col.MinimumWidth = 200;
                    //}
                    if (col.HeaderText == "DateCreate")
                    {
                        col.HeaderText = "Datum";
                        col.MinimumWidth = 150;
                    }
                    else if (col.HeaderText == "DateChange")
                    {
                        col.HeaderText = "Datun andern";
                        col.MinimumWidth = 200;
                    }
                    else if (col.HeaderText == "DateEnd")
                    {
                        col.HeaderText = "Enddatum";
                        col.MinimumWidth = 150;
                    }
                    else if (col.HeaderText == "Nr")
                    {
                        col.HeaderText = "Notiz";
                        col.MinimumWidth = 350;
                    }
                    else if (col.HeaderText == "Name")
                    {
                        col.HeaderText = "Beschreibung";
                        col.MinimumWidth = 350;
                    }
                    else if (col.HeaderText == "Summe")
                    {
                        col.HeaderText = "Betrag";
                        col.MinimumWidth = 150;
                    }
                    else if (col.HeaderText == "UserBudget")
                    {
                        col.HeaderText = "Nutzer";
                        col.MinimumWidth = 150;
                    }
                    else if (col.HeaderText == "IsEin")
                    {
                        col.HeaderText = "Ein/Aus";
                        col.MinimumWidth = 100;
                    }
                }
            }

            // see comments in extension method!!!
            datGridEingaben.ExpandColumns();
        }

        /// <summary>
        /// hide some columns,
        /// </summary>
        private void HideColumn()
        {
            //List colum to hide
            var hideColumns = new List<string>
                                  {
                                      "Id",
                                      "SummeEffectiv",
                                      "SummeRest",
                                      "IsEin",
                                      "IsFixe",
                                      "Monate",
                                      "Jahr",
                                      "DateChange"
                                  };

            foreach (var colName in hideColumns)
            {
                if (datGridEingaben.Columns.Contains(colName))
                {
                    datGridEingaben.Columns[colName].Visible = false;
                }
            }
        }

        /// <summary>
        /// Init grid column 
        /// </summary>
        private void InitColumn()
        {
            foreach (DataGridViewColumn col in datGridEingaben.Columns)
            {
                if (col.Name == "Summe")
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else if (col.Name == "DateCreate" || col.Name == "DateChange" || col.Name == "DateEnd"
                         || col.Name == "IsEin")
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        /// <summary>
        ///     Data bind two fields to labels
        /// </summary>
        private void SetupBudgetDataBindingsForLabels()
        {
            if (_blistBudget.Count > 0)
            {
                //Set label text
                labEingabeName.DataBindings.Add("text", _binSourcBudget, "Name");
                labEingabeSumme.DataBindings.Add("text", _binSourcBudget, "Summe");
            }
        }

        /// <summary>
        /// Reload and show summer
        /// </summary>
        public void LoadResultatCalculedForLabels()
        {
            var clsBudget = new Budgets();

            //Set eingaben summe
            labSumEingabe.Text = clsBudget.BudgetCalculed.SummeEin.ToString();
            labSumEingabe.Refresh();

            ///Set ausgaben summe
            labSumAusgabe.Text = clsBudget.BudgetCalculed.SummeAus.ToString();
            labSumAusgabe.Refresh();

            //Set difference
            labSumDiff.Text = clsBudget.BudgetCalculed.SummeDiff.ToString();

            if (!string.IsNullOrEmpty(labSumDiff.Text))
            {
                //change color if negativ
                if (double.Parse(labSumDiff.Text) < 0)
                {
                    labSumDiff.ForeColor = Color.Crimson;
                }
                else
                {
                    labSumDiff.ForeColor = Color.Black;
                }
            }

            labSumDiff.Refresh();

        }

        /// <summary>
        /// Clen filter
        /// </summary>
        private void btnSearchClean_Click(object sender, EventArgs e)
        {
            txtFilterName.Clear();

            cboFilterJahr.SelectedIndex = -1;
            cboFilterMonat.SelectedIndex = -1;

            cboUser.SelectedIndex = -1;

            chkFilterMonate.Checked = false;

            rbtFilterAus.Checked = false;
            rbtFilterEin.Checked = false;

            RemoveFilterBudget();
        }

        /// <summary>
        /// The search budget.
        /// </summary>
        public void SearchBudget()
        {
            // Set class
            var clsBudget = new Budgets();

            if (clsBudget.DataSource != null)
            {
                var parType = string.Empty;
                var parIsMonate = string.Empty;


                var parName = txtFilterName.Text;
                var parJahr = cboFilterJahr.GetItemText(cboFilterJahr.SelectedItem);
                var parMonate = cboFilterMonat.GetItemText(cboFilterMonat.SelectedItem);

                var parUser = this.cboUser.GetItemText(cboUser.SelectedItem);
                
                if (rbtFilterEin.Checked)
                {
                    parType = true.ToString();
                }
                else if (rbtFilterAus.Checked)
                {
                    parType = false.ToString();
                }

                if (chkFilterMonate.Checked)
                {
                    parIsMonate = true.ToString();
                }

                // laod and set budget filter if we have text else remove filter
                clsBudget.SerachValueFilter(parName, parJahr, parMonate, parType, parIsMonate,parUser);

                //Set list to grid
                _blistBudget = new SortableBindingList<Budget>(clsBudget.DataSource);
                _binSourcBudget.DataSource = _blistBudget;

                //set grid datasource
                datGridEingaben.DataSource = _binSourcBudget;


                if (_binSourcBudget.Count == 0)
                {
                    MessageBox.Show("Keine Treffer für eingegebenen Suchwert");
                }
                else
                {
                    LoadResultatCalculedForSearch(clsBudget.DataSource);

                    ResetCurrentBudget();
                }
            }
        }

        /// <summary>
        /// Resets the current budget.
        /// </summary>
        private void ResetCurrentBudget()
        {
            if (_binSourcBudget.CurrentRowIsValid())
            {
                if (_binSourcBudget.CurrentRowIsValid())
                {
                    _currentBudget = _binSourcBudget.BudgetCurrent();

                    _binSourcBudget.Position = _binSourcBudget.IndexOf(_currentBudget);

                    datGridEingaben.Rows[0].Selected = true;
                }
            }
            else
            {
                _currentBudget = null;
            }
        }

        /// <summary>
        ///     Remove filter
        /// </summary>
        private void RemoveFilterBudget()
        {
            Budget tempBudget = null;

            if (_binSourcBudget.CurrentRowIsValid())
            {
                tempBudget = _binSourcBudget.BudgetCurrent();
            }

            // Init and load class customers
            var clsBudget = new Budgets();

            _blistBudget = new SortableBindingList<Budget>(clsBudget.DataSource);

            _binSourcBudget.DataSource = _blistBudget;

            datGridEingaben.DataSource = _binSourcBudget;

            datGridEingaben.Rows[0].Selected = true;

            if (tempBudget != null && tempBudget.IsValidBudget())
            {
                _currentBudget = _blistBudget.FirstOrDefault(cust => cust.Id == tempBudget.Id);

                if (_currentBudget.IsValidBudget())
                {
                    _binSourcBudget.Position = _blistBudget.IndexOf(_currentBudget);

                }
            }
        }

        /// <summary>
        /// Loads the resultat calculed for search.
        /// </summary>
        /// <param name="listBudgetSearch">The list budget search.</param>
        public void LoadResultatCalculedForSearch(List<Budget> listBudgetSearch)
        {
            var clsBudget = new Budgets();

            clsBudget.CalResultBudgetsFilter(listBudgetSearch);

            //Set eingaben summe
            labSumEingabe.Text = clsBudget.BudgetCalculedFiltred.SummeEin.ToString();
            labSumEingabe.Refresh();
            ///Set ausgaben summe
            labSumAusgabe.Text = clsBudget.BudgetCalculedFiltred.SummeAus.ToString();
            labSumAusgabe.Refresh();
            //Set difference
            labSumDiff.Text = clsBudget.BudgetCalculedFiltred.SummeDiff.ToString();

            if (!string.IsNullOrEmpty(labSumDiff.Text) && labSumDiff.Text != "0")
            {
                //change color if negativ
                if (int.Parse(labSumDiff.Text.Substring(0, labSumDiff.Text.IndexOf(","))) < 0)
                {
                    labSumDiff.ForeColor = Color.Firebrick;
                }
                else
                {
                    labSumDiff.ForeColor = Color.Black;
                }
            }

            labSumDiff.Refresh();
        }

        private void labSumDiff_TextChanged(object sender, EventArgs e)
        {
            datGridEingaben.Update();
            datGridEingaben.Refresh();

        }

        private void datGridEingaben_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if header
            if (e.RowIndex == -1 && e.ColumnIndex != -1)
            {
                //set tooltip
                var txtToolTip = "Klicken zum Sortieren";

                datGridEingaben.Columns[3].ToolTipText = txtToolTip;
                datGridEingaben.Columns[4].ToolTipText = txtToolTip;
                datGridEingaben.Columns[5].ToolTipText = txtToolTip;
                datGridEingaben.Columns[8].ToolTipText = txtToolTip;
                datGridEingaben.Columns[12].ToolTipText = txtToolTip;
                datGridEingaben.Columns[13].ToolTipText = txtToolTip;
            }
        }
    }

}